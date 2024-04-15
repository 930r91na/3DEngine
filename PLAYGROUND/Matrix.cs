using System;

namespace PLAYGROUND
{
    public class Matrix
    {
        private readonly float[,] _data;

        private float this[int x, int y]
        {
            get { return _data[x, y]; }
            set { _data[x, y] = value; }
        }

        public Matrix(float[,] data)
        {
            this._data = data;
        }

        public static readonly Matrix Identity = new Matrix(new float[,]
        {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 0, 1 }
        });

        public static Matrix MakeScalingMatrix(float scale)
        {
            return new Matrix(new[,]
            {
                { scale, 0, 0, 0 },
                { 0, scale, 0, 0 },
                { 0, 0, scale, 0 },
                { 0, 0, 0, 1 }
            });
        }

        public static Vertex operator *(Matrix m, Vertex v)
        {
            var pts = new Vertex(0f, 0f, 0f, 0f)
            {
                X = (m[0, 0] * v.X) + (m[0, 1] * v.Y) + (m[0, 2] * v.Z) + (m[0, 3]),
                Y = (m[1, 0] * v.X) + (m[1, 1] * v.Y) + (m[1, 2] * v.Z) + (m[1, 3]),
                Z = (m[2, 0] * v.X) + (m[2, 1] * v.Y) + (m[2, 2] * v.Z) + (m[2, 3])
            };

            return pts;
        }


        public static Matrix RotX(float angle)
        {
            float cos = (float)Math.Cos(angle * Math.PI / 180.0);
            float sin = (float)Math.Sin(angle * Math.PI / 180.0);

            return new Matrix(new[,]
            {
                { 1, 0, 0, 0 },
                { 0, cos, -sin, 0 },
                { 0, sin, cos, 0 },
                { 0, 0, 0, 1 }
            });
        }

        public static Matrix RotY(float angle)
        {
            float cos = (float)Math.Cos(angle * Math.PI / 180.0);
            float sin = (float)Math.Sin(angle * Math.PI / 180.0);

            return new Matrix(new[,]
            {
                { cos, 0, sin, 0 },
                { 0, 1, 0, 0 },
                { -sin, 0, cos, 0 },
                { 0, 0, 0, 1 }
            });
        }

        public static Matrix RotZ(float angle)
        {
            float cos = (float)Math.Cos(angle * Math.PI / 180.0);
            float sin = (float)Math.Sin(angle * Math.PI / 180.0);

            return new Matrix(new[,]
            {
                { cos, -sin, 0, 0 },
                { sin, cos, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            });
        }


        public static Matrix operator *(Matrix m, Matrix r)
        {
            Matrix res = new Matrix(new float[4, 4])
            {
                [0, 0] = m[0, 0] * r[0, 0] + m[0, 1] * r[1, 0] + m[0, 2] * r[2, 0] + m[0, 3] * r[3, 0],
                [0, 1] = m[0, 0] * r[0, 1] + m[0, 1] * r[1, 1] + m[0, 2] * r[2, 1] + m[0, 3] * r[3, 1],
                [0, 2] = m[0, 0] * r[0, 2] + m[0, 1] * r[1, 2] + m[0, 2] * r[2, 2] + m[0, 3] * r[3, 2],
                [0, 3] = m[0, 0] * r[0, 3] + m[0, 1] * r[1, 3] + m[0, 2] * r[2, 3] + m[0, 3] * r[3, 3],
                [1, 0] = m[1, 0] * r[0, 0] + m[1, 1] * r[1, 0] + m[1, 2] * r[2, 0] + m[1, 3] * r[3, 0],
                [1, 1] = m[1, 0] * r[0, 1] + m[1, 1] * r[1, 1] + m[1, 2] * r[2, 1] + m[1, 3] * r[3, 1],
                [1, 2] = m[1, 0] * r[0, 2] + m[1, 1] * r[1, 2] + m[1, 2] * r[2, 2] + m[1, 3] * r[3, 2],
                [1, 3] = m[1, 0] * r[0, 3] + m[1, 1] * r[1, 3] + m[1, 2] * r[2, 3] + m[1, 3] * r[3, 3],
                [2, 0] = m[2, 0] * r[0, 0] + m[2, 1] * r[1, 0] + m[2, 2] * r[2, 0] + m[2, 3] * r[3, 0],
                [2, 1] = m[2, 0] * r[0, 1] + m[2, 1] * r[1, 1] + m[2, 2] * r[2, 1] + m[2, 3] * r[3, 1],
                [2, 2] = m[2, 0] * r[0, 2] + m[2, 1] * r[1, 2] + m[2, 2] * r[2, 2] + m[2, 3] * r[3, 2],
                [2, 3] = m[2, 0] * r[0, 3] + m[2, 1] * r[1, 3] + m[2, 2] * r[2, 3] + m[2, 3] * r[3, 3],
                [3, 0] = m[3, 0] * r[0, 0] + m[3, 1] * r[1, 0] + m[3, 2] * r[2, 0] + m[3, 3] * r[3, 0],
                [3, 1] = m[3, 0] * r[0, 1] + m[3, 1] * r[1, 1] + m[3, 2] * r[2, 1] + m[3, 3] * r[3, 1],
                [3, 2] = m[3, 0] * r[0, 2] + m[3, 1] * r[1, 2] + m[3, 2] * r[2, 2] + m[3, 3] * r[3, 2],
                [3, 3] = m[3, 0] * r[0, 3] + m[3, 1] * r[1, 3] + m[3, 2] * r[2, 3] + m[3, 3] * r[3, 3]
            };

            return res;
        }

        public static Matrix MakeTranslationMatrix(Vertex translation)
        {
            return new Matrix(new[,]
            {
                { 1, 0, 0, translation.X },
                { 0, 1, 0, translation.Y },
                { 0, 0, 1, translation.Z },
                { 0, 0, 0, 1 }
            });
        }

        internal static Matrix Inverse(Matrix rotation)
        {
            float[,] data = new float[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    data[i, j] = rotation._data[j, i];
                }
            }

            return new Matrix(data);
        }
    }
}