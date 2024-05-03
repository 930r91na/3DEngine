using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        }

        public Vertex Position;
        public float Intensity;
        public LightType Type { get; set; }

        public LightSource(Vertex position, float intensity, Canvas _canvas)
        {

            Position = new Vertex(position.X , position.Y , position.Z, position.H);
            Intensity = intensity;
            Type = LightType.Ambient;
        }

        public float CalculateLighting(Vertex v, Vertex normal)
        {
            float illumination = 0.1f;

            switch (Type)
            {
                case LightType.Ambient:
                    illumination = Intensity;
                    return illumination;

                case LightType.Point:
                    float dx = Position.X - v.X;
                    float dy = Position.Y - v.Y;
                    float dz = Position.Z - v.Z;
                    float distance = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);

                    // New attenuation calculation with tweaked coefficients
                    float Kc = 0.1f;  // Constant attenuation
                    float Kl = 0.01f;  // Linear attenuation
                    float Kq = 0.001f;  // Quadratic attenuation
                    float attenuation = 1f / (Kc + Kl * distance + Kq * distance * distance);

                    float intensity = Intensity;
                    illumination += intensity * attenuation;
                    return illumination;

                default:
                    return illumination;
            }
        }
    }
}
