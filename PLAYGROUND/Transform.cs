using System.Drawing.Drawing2D;

namespace PLAYGROUND
{
    public class Transform
    {
        public float Scale;
        public Vertex Translation;
        public Matrix Rotation { get; set; }


        public Transform(float scale, Vertex translation, Matrix rotation)
        {
            this.Scale = scale;
            this.Rotation = rotation ?? Matrix.Identity;
            this.Translation = translation.Clone();
        }

        public Transform Clone()
        {
            return new Transform(Scale, Translation.Clone(), Matrix.Identity);
        }

        public Matrix transform()
        {
            Matrix m = Matrix.MakeTranslationMatrix(this.Translation) * this.Rotation *
                       Matrix.MakeScalingMatrix(this.Scale);
            return m;
        }
    }
}