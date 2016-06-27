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
        private readonly PathPointType option;
 
        public Line(Pen pen, IList<Point> points, string option)
        {
            this.points = points;
            this.pen = pen;
            this.option = PathPointType.Line; // TODO: convert from option
        }

        public void Draw(Graphics graphics)
        {
            var pointTypes = points.Select(_ => (byte) option).ToArray();
            var path = new GraphicsPath(points.ToArray(), pointTypes);
            graphics.DrawPath(pen, path);
        }
    }
}