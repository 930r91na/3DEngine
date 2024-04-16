using System.Collections.Generic;
using System.Drawing;
using System;
using System.IO.Compression;
using System.Linq;

namespace PLAYGROUND
{
    public class Renderer
    {
        private readonly Canvas _canvas;
        private readonly List<LightSource> _lights;
        private readonly float[][] _depthBuffer;

        public Renderer(Canvas canvas, List <LightSource> lightSources, Camera camera)
        {
            this._canvas = canvas;
            _lights = lightSources;

            _depthBuffer = new float[canvas.Width][];
            for (var i = 0; i < canvas.Width; i++)
            {
                _depthBuffer[i] = new float[canvas.Height];
                for (var j = 0; j < canvas.Height; j++)
                {
                    _depthBuffer[i][j] = float.MaxValue;
                }
            }
        }
        public void ClearDepthBuffer()
        {
            for (int i = 0; i < _canvas.Width; i++)
            {
                for (int j = 0; j < _canvas.Height; j++)
                {
                    _depthBuffer[i][j] = float.MaxValue;
                }
            }
        }


        public void DrawPixel(int x, int y, float z, Color color)
        {
            x = _canvas.Width / 2 + x;
            y = _canvas.Height / 2 - y - 1;


            if (x < 0 || x >= _canvas.Width || y < 0 || y >= _canvas.Height)
            {
                return;
            }

            if (z > _depthBuffer[x][y]) return;

            _canvas.SetPixel(x, y, color);
            _depthBuffer[x][y] = z;
        }

        private void DrawLine(Vertex p0, Vertex p1, Color color)
        {
            var dx = p1.X - p0.X;
            var dy = p1.Y - p0.Y;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (dx < 0)
                {
                    (p0, p1) = (p1, p0);
                }

                var ys = Interpolate(p0.X, p0.Y, p1.X, p1.Y);
                for (var x = (int)p0.X; x <= p1.X; x++)
                {
                    DrawPixel(x, (int)ys[(x - (int)p0.X)], float.MaxValue, color);
                }
            }
            else
            {
                if (dy < 0)
                {
                    (p0, p1) = (p1, p0);
                }

                var xs = Interpolate((int)p0.Y, p0.X, (int)p1.Y, p1.X);
                for (var y = (int)p0.Y; y <= p1.Y; y++)
                {
                    DrawPixel((int)xs[(y - (int)p0.Y)], y, float.MaxValue ,color);
                }
            }
        }

        public void SortByY(ref Vertex p0, ref Vertex p1, ref Vertex p2)
        {
            // Sort the vertices
            if (p1.Y < p0.Y)
            {
                (p0, p1) = (p1, p0);
            }

            if (p2.Y < p0.Y)
            {
                (p0, p2) = (p2, p0);
            }

            if (p2.Y < p1.Y)
            {
                (p1, p2) = (p2, p1);
            }
        }

        private static List<float> Interpolate(float i0, float d0, float i1, float d1)
        {
            List<float> values = new List<float>();
            if (Math.Abs(i0 - i1) < 0.01f)
            {
                values.Add(d0);
                return values;
            }

            float a = (d1 - d0) / (i1 - i0);
            float d = d0;
            for (int i = (int)i0; i <= i1; i++)
            {
                values.Add(d);
                d = d + a;
            }

            return values;
        }



        // RENDER FUNCTIONS
        public void RenderScene(Camera camera, Scene scene)
        {
            var CameraMatrix = camera.GetCameraMatrix();
            _canvas.FastClear();
            ClearDepthBuffer();

            // Render Models
            for (var m = scene.Models.Count - 1; m >= 0; m--)
            {
                var sceneTransform = CameraMatrix * scene.Models[m].Transform.transform();

                RenderModel(camera, scene.Models[m].Mesh, sceneTransform, scene.Models[m].Mode);
            }

            // Render Lights
            for (var l = _lights.Count - 1; l >= 0; l--)
            {
                RenderLight(camera, _lights[l]);
            }

            _canvas.Refresh();
        }
        private void RenderLight(Camera c, LightSource light)
        {
           //Model l = light.GenerateModel();
            //RenderModel(c, l, )
           DrawPixel((int)light.Position.X, (int)light.Position.Y, float.MaxValue, Color.Red);
        }
        private void RenderModel(Camera c ,Mesh model, Matrix transform, Mode mode)
        {
            var projected = new List<Vertex>();

            for (var index = 0; index < model.Vertexes.Length; index++)
            {
                var t = model.Vertexes[index];
                projected.Add(c.Project(transform*t));
            }

            for (var t = model.Triangles.Length - 1; t >= 0; t--)
            {
                switch (mode)
                {
                    case Mode.Shaded:
                        RenderTriangle(model.Triangles[t], projected, Mode.Shaded);
                        break;
                    case Mode.Wireframe:
                        RenderTriangle(model.Triangles[t], projected, Mode.Wireframe);
                        break;
                    case Mode.Solid:
                        RenderTriangle(model.Triangles[t], projected, Mode.Solid);
                        break;
                    default:
                        RenderTriangle(model.Triangles[t], projected, Mode.Wireframe);
                        break;
                }
            }
        }

        public void RenderTriangle(Triangle triangle, List<Vertex> projected, Mode mode)
        {
            switch (mode)
            {
                case Mode.Shaded:
                    DrawShadedTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C], triangle.Color);
                    break;
                case Mode.Wireframe:
                    DrawWireFrameTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C],
                                               triangle.Color);
                    break;
                case Mode.Solid:
                    DrawFilledTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C],
                                               triangle.Color);
                    break;
                default:
                    DrawShadedTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C], triangle.Color);
                    break;
            }
        }

        public void DrawWireFrameTriangle(Vertex p0, Vertex p1, Vertex p2, Color color)
        {
            DrawLine(p0, p1, color);
            DrawLine(p1, p2, color);
            DrawLine(p2, p0, color);
        }

        public void DrawShadedTriangle(Vertex a, Vertex b, Vertex c, Color color)
        {
            Vertex p0 = new Vertex((int)a.X, (int)a.Y, (int)a.Z, a.H);
            Vertex p1 = new Vertex((int)b.X, (int)b.Y, (int)b.Z, b.H);
            Vertex p2 = new Vertex((int)c.X, (int)c.Y, (int)c.Z, c.H);

            // Sort the vertices
            SortByY(ref p0, ref p1, ref p2);

            // Get the normal of the triangle
            var normal = CalculateNormal(p0, p1, p2);

            // Get the lighting of the vertices
            CalculateLighting(p0, normal);
            CalculateLighting(p1, normal);
            CalculateLighting(p2, normal);

            // Calculate x coordinates
            var x01 = Interpolate(p0.Y, p0.X, p1.Y, p1.X);
            var x12 = Interpolate(p1.Y, p1.X, p2.Y, p2.X);
            var x02 = Interpolate(p0.Y, p0.X, p2.Y, p2.X);

            // Calculate h 
            var h01 = Interpolate(p0.Y, p0.H, p1.Y, p1.H);
            var h12 = Interpolate(p1.Y, p1.H, p2.Y, p2.H);
            var h02 = Interpolate(p0.Y, p0.H, p2.Y, p2.H);

            // Calculate z coordinates
            var z01 = Interpolate(p0.Y, p0.Z, p1.Y, p1.Z);
            var z12 = Interpolate(p1.Y, p1.Z, p2.Y, p2.Z);
            var z02 = Interpolate(p0.Y, p0.Z, p2.Y, p2.Z);

            // Ensure lists are not empty before removing an element
            if (x01.Count > 0 && x12.Count > 0 && IsOverlapping(x01, x12))
            {
                x01.RemoveAt(x01.Count - 1);
            }
            List<float> x012 = [.. x01, .. x12];

            if (z01.Count > 0 && z12.Count > 0)
            {
                z01.RemoveAt(z01.Count - 1);
            }
            List<float> z012 = [.. z01, .. z12];

            if (h01.Count > 0 && h12.Count > 0)
            {
                h01.RemoveAt(h01.Count - 1);
            }
            List<float> h012 = [.. h01, .. h12];

            // Determine each side
            List<float> xLeft, xRight, zLeft, zRight, hLeft, hRight;

            // Ensure x012 and x02 have elements before accessing them
            if (x012.Count == 0 || x02.Count == 0)
            {
                return;
            }
            if (z012.Count == 0 || z02.Count == 0)
            {
                return;
            }
            if (h012.Count == 0 || h02.Count == 0)
            {
                return;
            }

            var m = Math.Floor((decimal)x02.Count / 2);

            if (x02.Count > (int)m && x012.Count > (int)m && x02[(int)m] < x012[(int)m])
            {
                xLeft = x02;
                xRight = x012;
                zLeft = z02;
                zRight = z012;
                hLeft = h02;
                hRight = h012;
            }
            else
            {
                xLeft = x012;
                xRight = x02;
                zLeft = z012;
                zRight = z02;
                hLeft = h012;
                hRight = h02;
            }

            // Fill the triangle
            for (var y = (int)p0.Y; y <= p2.Y; y++)
            {
                int index = y - (int)p0.Y;
                if (index < 0 || index >= xLeft.Count) continue;

                var xl = xLeft[index];
                var xr = xRight[index];
                var zl = zLeft[index];
                var zr = zRight[index];
                var hl = hLeft[index];
                var hr = hRight[index];

                var zSegment = Interpolate(xl, zl, xr, zr);
                var hSegment = Interpolate(xl, hl, xr, hr);

                for (float x = xl; x < xr; x++)
                {
                    index = (int)x - (int)xl;

                    if (index < 0 || index >= hSegment.Count) continue;

                    var shaded = Mult(color, hSegment[index]);
                    DrawPixel((int)x, y, zSegment[index], shaded);
                }
            }
        }

        public void DrawFilledTriangle(Vertex a, Vertex b, Vertex c, Color color)
        {
            Vertex p0 = new Vertex((int)a.X, (int)a.Y, (int)a.Z, a.H);
            Vertex p1 = new Vertex((int)b.X, (int)b.Y, (int)b.Z, b.H);
            Vertex p2 = new Vertex((int)c.X, (int)c.Y, (int)c.Z, c.H);

            // Sort the vertices
            SortByY(ref p0, ref p1, ref p2);

            // Calculate x coordinates
            var x01 = Interpolate(p0.Y, p0.X, p1.Y, p1.X);
            var x12 = Interpolate(p1.Y, p1.X, p2.Y, p2.X);
            var x02 = Interpolate(p0.Y, p0.X, p2.Y, p2.X);

            var z01 = Interpolate(p0.Y, 1/p0.Z, p1.Y, 1 / p1.Z);
            var z12 = Interpolate(p1.Y, 1/p1.Z, p2.Y, 1 / p2.Z);
            var z02 = Interpolate(p0.Y, 1 / p0.Z, p2.Y, 1 / p2.Z);;

            // Ensure lists are not empty before removing an element
            if (x01.Count > 0 && x12.Count > 0 && IsOverlapping(x01, x12))
            {
                x01.RemoveAt(x01.Count - 1);
            }
            if (z01.Count > 0 && z12.Count > 0)
            {
                z01.RemoveAt(z01.Count - 1);
            }

            var x012 = x01.Concat(x12).ToList();
            var z012 = z01.Concat(z12).ToList();

            // Determine each side
            List<float> xLeft, xRight, zLeft, zRight;

            // Ensure x012 and x02 have elements before accessing them
            if (x012.Count == 0 || x02.Count == 0)
            {
                return;
            }

            var m = Math.Floor((decimal)x012.Count / 2);
            if (x02.Count > (int)m && x012.Count > (int)m && x02[(int)m] < x012[(int)m])
            {
                xLeft = x02;
                xRight = x012;
                zLeft = z02;
                zRight = z012;
            }
            else
            {
                xLeft = x012;
                xRight = x02;
                zLeft = z012;
                zRight = z02;
            }

            // Fill the triangle
            for (var y = (int)p0.Y; y <= p2.Y; y++)
            {
                var index = y - (int)p0.Y;

                if (index < 0 || index >= xLeft.Count || index >= xRight.Count || index >= zLeft.Count || index >= zRight.Count) continue;

                var xr = xRight[index];
                var xl = xLeft[index];
                var zl = zLeft[index];
                var zr = zRight[index];

                var zSegment = Interpolate(xl, 1 / zl, xr, 1/zr);

                for (int x = (int)xl; x <= xr; x++)
                 {
                    DrawPixel(x, y, zSegment[(int)(x - xl)], color);
                }
            }
        }

        private static bool IsOverlapping(List<float> x01, List<float> x12)
        {
            if (!x01.Any() || !x12.Any())
            {
                return false;
            }

            var lastPointOfX01 = x01.Last();
            var firstPointOfX12 = x12.First();


            return Math.Abs(lastPointOfX01 - firstPointOfX12) < 0.01;
        }

        private Vertex CalculateNormal(Vertex p0, Vertex p1, Vertex p2)
        {
            // Calculate vectors from the points
            Vertex u = new Vertex(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z, 0);
            Vertex v = new Vertex(p2.X - p0.X, p2.Y - p0.Y, p2.Z - p0.Z, 0);

            // Calculate the cross product
            float nx = u.Y * v.Z - u.Z * v.Y;
            float ny = u.Z * v.X - u.X * v.Z;
            float nz = u.X * v.Y - u.Y * v.X;

            return new Vertex(nx, ny, nz, 0);  
        }

        public static Color Mult(Color color, float scalar)
        {
            // Calculate new RGB values
            var r = (int)(color.R * scalar);
            var g = (int)(color.G * scalar);
            var b = (int)(color.B * scalar);

            // Clamp values to the 0-255 range
            r = Math.Max(0, Math.Min(255, r));
            g = Math.Max(0, Math.Min(255, g));
            b = Math.Max(0, Math.Min(255, b));

            // Create a new color with the adjusted RGB values
            return Color.FromArgb(color.A, r, g, b);
        }

        // Calculate the lighting of a vertex
        private void CalculateLighting(Vertex vertex, Vertex normal)
        {
            for (int l = 0; l < _lights.Count; l++)
            {
                var light = _lights[l];

                light.CalculateLighting(vertex, normal);
            }
        }
    }
}