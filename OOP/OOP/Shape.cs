using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     public abstract class Shape
    {

        public Color PenColor { get; set; }
        public int PenWidth { get; set; }

        public Point PositionStart { get; set; }
        public Point PositionEnd { get; set; }

        public abstract void Draw(Graphics g);


    }
}
