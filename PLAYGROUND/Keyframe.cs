using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class Keyframe
    {
        public Vertex Position { get; set; }

        public Transform Transform { get; set; }
        public int Time { get; set; }

        public Keyframe(Vertex position, Transform transform, int time) {
            Position = position;
            Transform = transform;
            Time = time;
        }
    }
}
