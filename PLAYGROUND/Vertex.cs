using System;

namespace PLAYGROUND
{
    public class Vertex
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float H { get; set; }


        public Vertex(float x, float y, float z, float h)
        {
            X = x;
            Y = y;
            Z = z;
            H = h;
        }

        internal static float DotProduct(Vertex a, Vertex b)
        {
            // Calculate the dot product of two vectors
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        internal static float Distance(Vertex position, Vertex v)
        {
            return (float)Math.Sqrt(Math.Pow(position.X - v.X, 2) + Math.Pow(position.Y - v.Y, 2) + Math.Pow(position.Z - v.Z, 2));
        }
    }
}