using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Line : Shape
    {
        public Point PositionEnd { get; set; }
        public Line(Color color, int width, Point start, Point end) {
            this.PenColor = color;
            this.PenWidth = width;
            this.PositionStart = start;
            this.PositionEnd = end;
        }
        public override void Draw(Graphics g) {
            using (var pen = new Pen(PenColor, PenWidth)) {
                g.DrawLine(pen, PositionStart, PositionEnd);

            }
        }

    }
}
