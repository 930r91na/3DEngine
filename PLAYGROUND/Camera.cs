using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLAYGROUND
{
    public class Camera
    {
        private readonly Canvas _canvas;

        // Position of the camera and orientation
        public Vertex Position { get; set; }
        public Matrix Orientation { get; set; }

        public Transform Transform;

        // Viewport parameters
        private const float Distance = 1.0f;
        public float ViewportWidth { get; set; }
        public float ViewportHeight { get; set; }

        public Camera(Canvas canvas, Transform transform)
        {
            this._canvas = canvas;
            ViewportHeight = 1;
            ViewportWidth = ((float)canvas.Width / canvas.Height) * ViewportHeight;
            Transform = transform;
        }

        public Vertex Project(Vertex vertex)
        {
            return ViewPortToCanvas(new Vertex(vertex.X * Distance / vertex.Z, vertex.Y * Distance / vertex.Z, vertex.Z, vertex.H));
        }

        public Vertex ViewPortToCanvas(Vertex vertex)
        {
            return new Vertex(vertex.X * _canvas.Width/ViewportWidth,vertex.Y *_canvas.Height/ViewportHeight,vertex.Z,vertex.H);
        }

        
        public Matrix GetCameraMatrix()
        {
            Matrix inverseRotation = Matrix.Inverse(Transform.Rotation);
            Matrix inverseTranslation = Matrix.MakeTranslationMatrix(new Vertex(-Transform.Translation.X, -Transform.Translation.Y, -Transform.Translation.Z, -Transform.Translation.H));

            Matrix cameraMatrix = inverseRotation * inverseTranslation;

            return cameraMatrix;
        }


    }
}
