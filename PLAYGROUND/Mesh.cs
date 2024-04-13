using System.Collections.Generic;

namespace PLAYGROUND
{
    public class Mesh
    {
        public readonly Vertex[] Vertexes;
        public readonly Triangle[] Triangles;

        public Mesh(Vertex[] vertexes, Triangle[] triangles)
        {
            Vertexes = vertexes;
            Triangles = triangles;
        }
    }
}