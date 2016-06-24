using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LePaint.Objects
{
    internal class Line : IObject
    {
        private readonly IList<Point> points;
        private readonly Pen pen;
 
        public Line(Pen pen, IList<Point> points)
        {
            this.points = points;
            this.pen = pen;
        }

        public void Draw(Graphics graphics)
        {
            Point first = Point.Empty;
            foreach (var second in points)
            {
                if (first != Point.Empty && second != Point.Empty)
                {
                    DrawSegment(graphics, first, second);
                }
                first = second;
            }
        }

        private void DrawSegment(Graphics graphics, Point first, Point second)
        {
            graphics.DrawLine(pen, first, second);
        }
    }
}