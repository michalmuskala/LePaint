using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            var pointTypes = points.Select(_ => (byte) PathPointType.Line).ToArray();
            var path = new GraphicsPath(points.ToArray(), pointTypes);
            graphics.DrawPath(pen, path);
        }
    }
}