using System.Collections.Generic;
using System.Drawing;
using System;
using System.Linq;

namespace PLAYGROUND
{
    public class Renderer
    {
        private readonly Canvas _canvas;
        private readonly Camera _camera;

        public Renderer(Canvas canvas)
        {
            this._canvas = canvas;
            _camera = new Camera(canvas);
        }

        public void DrawPixel(int x, int y, Color color)
        {
            x = _canvas.Width / 2 + x;
            y = _canvas.Height / 2 - y - 1;

            if (x < 0 || x >= _canvas.Width || y < 0 || y >= _canvas.Height)
            {
                return;
            }

            _canvas.SetPixel(x, y, color);
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

                var ys = Interpolate((int)p0.X, p0.Y, (int)p1.X, p1.Y);
                for (var x = (int)p0.X; x <= p1.X; x++)
                {
                    DrawPixel(x, (int)ys[(x - (int)p0.X)], color);
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
                    DrawPixel((int)xs[(y - (int)p0.Y)], y, color);
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
            if (Math.Abs(i0 - i1) < 0)
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
        public void RenderScene(Scene scene)
        {
            _canvas.FastClear();
            for (var m = scene.Models.Count - 1; m >= 0; m--)
            {
                RenderModel(scene.Models[m].Mesh, scene.Models[m].Transform.transform(), scene.Models[m].Mode);
            }

            _canvas.Refresh();
        }

        private void RenderModel(Mesh model, Matrix transform, Mode mode)
        {
            var projected = new List<Vertex>();

            for (var index = 0; index < model.Vertexes.Length; index++)
            {
                var t = model.Vertexes[index];
                projected.Add(_camera.Project(transform*t));
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
                    DrawShadowedTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C],
                        triangle.Color);
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
                    DrawWireFrameTriangle(projected[triangle.A], projected[triangle.B], projected[triangle.C],
                        triangle.Color);
                    break;
            }
        }

        public void DrawWireFrameTriangle(Vertex p0, Vertex p1, Vertex p2, Color color)
        {
            DrawLine(p0, p1, color);
            DrawLine(p1, p2, color);
            DrawLine(p2, p0, color);
        }

        public void DrawFilledTriangle(Vertex p0, Vertex p1, Vertex p2, Color color)
        {
            // Sort the vertices
            SortByY(ref p0, ref p1, ref p2);

            // Calculate x coordinates
            var x01 = Interpolate(p0.Y, p0.X, p1.Y, p1.X);
            var x12 = Interpolate(p1.Y, p1.X, p2.Y, p2.X);
            var x02 = Interpolate(p0.Y, p0.X, p2.Y, p2.X);

            // Ensure lists are not empty before removing an element
            if (x01.Count > 0 && x12.Count > 0 && IsOverlapping(x01, x12))
            {
                //x01.RemoveAt(x01.Count - 1);
            }

            var x012 = x01.Concat(x12).ToList();

            // Determine each side
            List<float> xLeft, xRight;

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
            }
            else
            {
                xLeft = x012;
                xRight = x02;
            }

            // Fill the triangle
            for (var y = (int)p0.Y; y <= p2.Y; y++)
            {
                var xl = 0;
                var yPos = y - (int)p0.Y;

                if (yPos >= 0 && yPos < xLeft.Count)
                {
                    xl = (int)xLeft[yPos];
                }

                var xr = yPos >= 0 && yPos < xRight.Count ? (int)xRight[yPos] : 0;

                for (var x = xl; x <= xr && x >= 0; x++)
                {
                    DrawPixel(x, y, color);
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


        public void DrawShadowedTriangle(Vertex p0, Vertex p1, Vertex p2, Color color)
        {
            SortByY(ref p0, ref p1, ref p2);

            // Calculate x coordinates, h and z values
            var x01 = Interpolate(p0.Y, p0.X, p1.Y, p1.X);
            var x12 = Interpolate(p1.Y, p1.X, p2.Y, p2.X);
            var x02 = Interpolate(p0.Y, p0.X, p2.Y, p2.X);
            var h01 = Interpolate(p0.Y, p0.H, p1.Y, p1.H);
            var h12 = Interpolate(p1.Y, p1.H, p2.Y, p2.H);
            var h02 = Interpolate(p0.Y, p0.H, p2.Y, p2.H);

            // Ensure lists are not empty before removing an element
            if (x01.Count > 0 && x12.Count > 0 && IsOverlapping(x01, x12))
            {
                x01.RemoveAt(x01.Count - 1);
            }

            if (h01.Count > 0 && h12.Count > 0 && IsOverlapping(h01, h12))
            {
                h01.RemoveAt(h01.Count - 1);
            }

            var x012 = x01.Concat(x12).ToList();
            var h012 = h01.Concat(h12).ToList();

            // Determine each side
            List<float> xLeft, xRight, hLeft, hRight;

            var m = Math.Floor((decimal)x012.Count / 2);

            // Ensure x012 and x02 have elements before accessing them
            if (x012.Count == 0 || x02.Count == 0 || x02.Count > m || x012.Count > m)
            {
                return;
            }

            // Ensure h012 and h02 have elements before accessing them
            if (h012.Count == 0 || h02.Count == 0)
            {
                return;
            }


            if (x02[(int)m] < x012[(int)m])
            {
                xLeft = x02;
                xRight = x012;
                hLeft = h02;
                hRight = h012;
            }
            else
            {
                xLeft = x012;
                xRight = x02;
                hLeft = h012;
                hRight = h02;
            }

            // Fill the triangle
            for (var y = (int)p0.Y; y <= p2.Y; y++)
            {
                var index = y - (int)p0.Y;

                if (index < 0 || index >= xLeft.Count || index >= xRight.Count)
                {
                    continue; // Skip this iteration if the index is out of bounds
                }

                var xl = (int)xLeft[y - (int)p0.Y];
                var xr = (int)xRight[y - (int)p0.Y];

                if (hLeft.Count < 0 || hRight.Count < 0)
                {
                    return;
                }

                if (index >= hLeft.Count || index >= hRight.Count)
                {
                    continue; // Skip this iteration if the index is out of bounds
                }

                var hSegment = Interpolate(xl, hLeft[y - (int)p0.Y], xr, hRight[y - (int)p0.Y]);

                for (var x = xl; x <= xr; x++)
                {
                    var shadedColor = Mult(color, hSegment[x - xl]);

                    DrawPixel(x, y, shadedColor);
                }
            }
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

        // CLIPPING FUNCTIONS
    }
}