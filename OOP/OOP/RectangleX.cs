using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class RectangleX : RectangleSh
    {

        public RectangleX(Color color, int penWidth, Point position, int width, int height)
            : base(color, penWidth, position, width, height)
        { 
        }

        public override void Draw(Graphics g)
        {

            using (var pen = new Pen(PenColor, PenWidth))
            {
                Rectangle rect = GetRect();
                g.DrawRectangle(pen, rect);
            }

        }



    }
}
