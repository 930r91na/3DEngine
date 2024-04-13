using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class Camera
    {
        private readonly Canvas _canvas;
        private const float Distance = 1.0f;
        public float ViewportWidth { get; set; }
        public float ViewportHeight { get; set; }

        public Camera(Canvas canvas)
        {
            this._canvas = canvas;
            ViewportHeight = 1;
            ViewportWidth = ((float)canvas.Width / canvas.Height) * ViewportHeight;
        }

        // PROJECTION FUNCTIONS 
        public Vertex Project(Vertex vertex)
        {
            return ViewPortToCanvas(new Vertex(vertex.X * Distance / vertex.Z, vertex.Y * Distance / vertex.Z,0, vertex.H));
        }

        public Vertex ViewPortToCanvas(Vertex vertex)
        {
            return new Vertex(vertex.X * _canvas.Width/ViewportWidth,vertex.Y *_canvas.Height/ViewportHeight,0,vertex.H);
        }

        //private Vertex ProjectVertex(Vertex v)
        //{
        //    // Project the 3D coordinates into the 2D viewport
        //    return ViewportToCanvas(new Vertex(v.X * ProjectionPlaneZ / (v.Z), v.Y * ProjectionPlaneZ / (v.Z), 0, 0));
        //}
        //
        //private Vertex ViewportToCanvas(Vertex p2d)
        //{
        //    // The viewport is proportional to the canvas but normalized to 0-1
        //    var vH = _canvas.Height;
        //    var vW = ((float)_canvas.Width / _canvas.Height) * vH;
        //
        //    // Convert the normalized viewport to canvas coordinates
        //    return new Vertex((p2d.X * _canvas.Width / vW), (p2d.Y * _canvas.Height / vH), 0, 0);
        //}
    }
}
