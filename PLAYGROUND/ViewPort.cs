using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class ViewPort
    {
        private readonly Canvas _canvas;
        private Transform transformations;
        private const float Distance = 1.0f;
        public float ViewportWidth { get; set; }
        public float ViewportHeight { get; set; }

        public ViewPort(Canvas canvas)
        {
            this._canvas = canvas;
            ViewportHeight = 1;
            ViewportWidth = ((float)canvas.Width / canvas.Height) * ViewportHeight;
        }

        public Vertex Project(Vertex vertex)
        {
            return ViewPortToCanvas(new Vertex(vertex.X * Distance / vertex.Z, vertex.Y * Distance / vertex.Z, vertex.Z, vertex.H));
        }

        public Vertex ViewPortToCanvas(Vertex vertex)
        {
            return new Vertex(vertex.X * _canvas.Width/ViewportWidth,vertex.Y *_canvas.Height/ViewportHeight,vertex.Z,vertex.H);
        }
    }
}
