using System.Drawing;

namespace PLAYGROUND
{
    public class Triangle
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public Color Color;

        public Triangle(int a, int b, int c, Color color)
        {
            A = a;
            B = b;
            C = c;
            Color = color;

        }
    }
}
