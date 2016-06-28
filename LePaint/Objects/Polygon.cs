using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LePaint.Objects
{
    internal class Polygon : IObject
    {
        private bool filled;
        private Point[] path;
        private Pen pen;

        public Polygon(Pen pen, bool filled, IEnumerable<Point> path)
        {
            this.pen = pen;
            this.filled = filled;
            this.path = path.ToArray();
        }

        public void Draw(Graphics graphics)
        {
            if (filled)
                graphics.FillClosedCurve(pen.Brush, path);
            else
                graphics.DrawClosedCurve(pen, path);
        }
    }
}