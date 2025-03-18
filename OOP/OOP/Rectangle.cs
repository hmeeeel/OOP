using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOP
{
    // для эллипса и для прямоцгольника
    public abstract class RectangleSh : Shape
    {

        public int Width { get; }
        public int Height { get; }


        protected RectangleSh(Color color, int penWidth, Point position, int width, int height)
        {
            PenColor = color;
            PenWidth = penWidth;
            PositionStart = position;
            Width = width;
            Height = height;
        }

        public Rectangle GetRect()
        {
            return new Rectangle(PositionStart.X, PositionStart.Y, Width, Height);
        }

       
    }
}
