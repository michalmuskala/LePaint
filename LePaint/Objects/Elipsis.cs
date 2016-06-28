using System.Drawing;

namespace LePaint.Objects
{
    internal class Elipsis : Rectangle
    {

        public Elipsis(Pen pen, bool filled, Point point1, Point point2)
            : base(pen, filled, point1, point2)
        {
        }

        public override void Draw(Graphics graphics)
        {
            if (filled)
                graphics.FillEllipse(pen.Brush, rectangle);
            else
                graphics.DrawEllipse(pen, rectangle);
        }
    }
}