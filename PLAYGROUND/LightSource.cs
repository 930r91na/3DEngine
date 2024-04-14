using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    
        
    public class LightSource
    {
        public enum LightType
        {
            Flat,
            Gouraud,
            Phong
        }

        public Vertex Position;
        public float Intensity;
        public LightType Type { get; set; }

        public LightSource(Vertex position, float intensity)
        {
            Position = position;
            Intensity = intensity;
            Type = LightType.Flat;
        }

        public void CalculateLighting(Vertex v, Vertex normal)
        {
            var illumination = 0f;
            float a = 0.1f;
            float b = 5f;

            switch (Type)
            {
                case LightType.Flat:
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
                        var intensity = Math.Max(dotProduct, 0) * Intensity;

                        illumination += intensity * (float)attenuation;

                        v.H = illumination;
                    break;
                case LightType.Gouraud:
                    // TODO: Implement Gouraud shading
                        
                    break;
                case LightType.Phong:
                    // TODO: Implement Phong shading
                    break;
            }
        }


        
    }
}
