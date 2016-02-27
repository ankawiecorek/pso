using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO
{
    public class ImageParticle
    {
        public Point Position { get; set; }
        public Point BestPosition { get; set; }
        public Point Velocity { get; set; }
    }
}
