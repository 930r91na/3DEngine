using System.Collections.Generic;

namespace PLAYGROUND
{
    public class Mesh
    {
        public readonly Vertex[] Vertexes;
        public readonly Triangle[] Triangles;
        public readonly int indexMesh;

        public Mesh(Vertex[] vertexes, Triangle[] triangles, int indexMesh)
        {
            Vertexes = vertexes;
            Triangles = triangles;
            this.indexMesh = indexMesh;
        }
    }
}