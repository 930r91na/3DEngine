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
            Directional,
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

            switch (Type)
            {
                case LightType.Ambient:
                        illumination = Intensity;
                        v.H += illumination; 
                    break;

                case LightType.Point:
                        // Calculate the logarithmic attenuation
                        var attenuation = 1f / (a + b * Math.Log10(1 + distance));
                        Vertex nLight = Normalize(new Vertex(dx,dy,dz,1));

                        float dotProduct = Vertex.DotProduct(normal, nLight);
                        var intensity = Math.Abs(dotProduct) * Intensity;

                        illumination += intensity * (float)attenuation;
                        v.H += illumination;
                    break;

                case LightType.Directional:
                    nLight = Normalize(Position);
                    attenuation = 1f / (a + b * Math.Log10(1 + distance));
                    float ilum = Vertex.DotProduct(v, nLight) * 0.1f;
                    v.H += (ilum * (float)attenuation);
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
