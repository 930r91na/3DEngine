using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLAYGROUND
{
    
        
    public class LightSource
    {
        public enum LightType
        {
            Ambient,
            Point,
            PointNotSmooth,
        }

        public Vertex Position;
        public float Intensity;
        public LightType Type { get; set; }

        public LightSource(Vertex position, float intensity)
        {
            Position = position;
            Intensity = intensity;
            Type = LightType.Ambient;
        }

        public void CalculateLighting(Vertex v, Vertex normal)
        {
            var illumination = 0.1f;
            float a = 1f;
            float b = 5f;
            float dx = Position.X - v.X;
            float dy = Position.Y - v.Y;
            float dz = Position.Z - v.Z;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
            var attenuation = 1f / (a + b * Math.Log10(1 + distance));
            Vertex nLight = Normalize(new Vertex(dx, dy, dz, 1));


            switch (Type)
            {
                case LightType.Ambient:
                        illumination = Intensity;
                        v.H += illumination; 
                    break;

                case LightType.Point:
                    Vertex v2 = Normalize(new Vertex(dx, dy, dz, 1));
                    float dotProduct = Vertex.DotProduct(v2, nLight);
                    var intensity = Math.Abs(dotProduct) * Intensity * 100;

                    illumination += intensity * (float)attenuation;
                    v.H += illumination;

                    
                    break;

                case LightType.PointNotSmooth:
                    var attenuation2 = 1f / (a + b * Math.Log10(1 + distance));
                    Vertex nLight2 = Normalize(new Vertex(dx, dy, dz, 1));

                    float dotProduct2 = Vertex.DotProduct(normal, nLight2);
                    intensity = Math.Abs(dotProduct2) * Intensity;

                    illumination += intensity * (float)attenuation2;
                    v.H += illumination;
                    break;
            }
        }

        private Vertex Normalize(Vertex v)
        {
            float length = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            v.X /= length;
            v.Y /= length;
            v.Z /= length;

            return v;
        }

        
    }
}
