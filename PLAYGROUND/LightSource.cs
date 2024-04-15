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
            float a = 0.1f;
            float b = 5f;

            switch (Type)
            {
                case LightType.Ambient:
                        illumination += Intensity;
                        v.H += illumination; 
                    break;

                case LightType.Point:
                        float dx = Position.X - v.X;
                        float dy = Position.Y - v.Y;
                        float dz = Position.Z - v.Z;
                        float distance = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);

                        // Calculate the logarithmic attenuation
                        var attenuation = 1f / (a + b * Math.Log10(1 + distance));

                        float lightDirX = dx / distance;
                        float lightDirY = dy / distance;
                        float lightDirZ = dz / distance;

                        float dotProduct = normal.X * lightDirX + normal.Y * lightDirY + normal.Z * lightDirZ;
                        var intensity = Math.Abs(dotProduct) * Intensity;

                        illumination += intensity * (float)attenuation;
                        v.H += illumination;

                    break;

                case LightType.Directional:
                        // Not yet implemented
                    break;
            }
        }


        
    }
}
