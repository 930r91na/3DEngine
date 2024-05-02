﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Mode
{
    Wireframe,
    Solid,
    Shaded
}

namespace PLAYGROUND
{
    public class Model
    {
        public Vertex Position;
        public Mesh Mesh;
        public Transform Transform;
        public Mode Mode;

        // Animation
        private List<Keyframe> _keyframes = new List<Keyframe>();

        // Getters and Setters
        public Vertex GetPosition() { return Position; }
        public Transform GetTransform() { return Transform; }

        public Model(Vertex position, Mesh mesh, Transform transform)
        {
            Position = position;
            Mesh = mesh;
            Transform = transform;
            this.Mode = Mode.Wireframe;
            _keyframes.Clear();
        }

        // Animation
        public void AddKeyFrame(Keyframe keyframe)
        {
            // Check if a Keyframe already exists
            if (!_keyframes.Any(k => k.Time == keyframe.Time))
            {
                _keyframes.Add(keyframe);
                _keyframes = _keyframes.OrderBy(k => k.Time).ToList();
            }
            else
            {
                // Opcional: Notificar al usuario que ya existe un Keyframe en ese tiempo
                Console.WriteLine("A keyframe at this time already exists.");
            }
        }

        public void Interpolate(int currentTime)
        {
            if (_keyframes.Count == 0)
                return;

            Keyframe start = _keyframes.LastOrDefault(k => k.Time <= currentTime);
            Keyframe end = _keyframes.FirstOrDefault(k => k.Time >= currentTime);

            if (start == null) // If before the first keyframe, use the first keyframe state.
                start = _keyframes.First();

            if (end == null) // If after the last keyframe, use the last keyframe state.
                end = _keyframes.Last();

            // If there's only one keyframe or the current time is exactly on a keyframe, apply that keyframe's state directly.
            if (start == end)
            {
                ApplyKeyframeState(start);
            }
            else // There has to be an interpolation for the animation
            {
                float lerpFactor = (float)(currentTime - start.Time) / (end.Time - start.Time);
                
                // Position
                Position.X = Lerp(start.Position.X, end.Position.X, lerpFactor);
                Position.Y = Lerp(start.Position.Y, end.Position.Y, lerpFactor);
                Position.Z = Lerp(start.Position.Z, end.Position.Z, lerpFactor);
                Position.H = Lerp(start.Position.H, end.Position.H, lerpFactor);

                // Transform
                Transform.Scale = Lerp(start.Transform.Scale, end.Transform.Scale, lerpFactor);
                Transform.Translation.X = Lerp(start.Transform.Translation.X, end.Transform.Translation.X, lerpFactor);
                Transform.Translation.Y = Lerp(start.Transform.Translation.Y, end.Transform.Translation.Y, lerpFactor);
                Transform.Translation.Z = Lerp(start.Transform.Translation.Z, end.Transform.Translation.Z, lerpFactor);
                Transform.Translation.H = Lerp(start.Transform.Translation.H, end.Transform.Translation.H, lerpFactor);

                // Rotation
                Matrix interpolatedRotation = Matrix.InterpolateMatrices(start.Transform.Rotation, end.Transform.Rotation, lerpFactor);
                Transform.Rotation = interpolatedRotation;
                
            }
        }

        private Matrix InterpolateMatrices(Matrix start, Matrix end, float factor)
        {
            float[,] interpolatedData = new float[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    interpolatedData[i, j] = Lerp(start[i, j], end[i, j], factor);
                }
            }
            return new Matrix(interpolatedData);
        }

        // Set the Keyframe properties to the Model
        private void ApplyKeyframeState(Keyframe keyframe)
        {
            Position = keyframe.Position;
            Transform = keyframe.Transform;
        }

        private float Lerp(float start, float end, float factor)
        {
            return (start * (1 - factor)) + (end * factor);
        }
    }
}