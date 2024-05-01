using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    internal class Keyframe
    {
        public PointF Translation { get; set; }
        public float Rotation { get; set; }
        public float Escalation { get; set; }
        public int Time { get; set; }

        public Keyframe(PointF translation, float rotation, float escalation, int time) {
            Translation = translation;
            Rotation = rotation;
            Escalation = escalation;
            Time = time;
        }
    }
}
