using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Mode
{
    Wireframe,
    Solid,
    Shaded
}

namespace PLAYGROUND
{
    public class Model
    {
        public Vertex Position;
        public Mesh Mesh;
        public Transform Transform;
        public Mode Mode;


        public Model(Vertex position, Mesh mesh, Transform transform)
        {
            Position = position;
            Mesh = mesh;
            Transform = transform;
            this.Mode = Mode.Wireframe;
        }
    }
}