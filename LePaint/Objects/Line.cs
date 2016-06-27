using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace LePaint.Objects
{
    internal class Line : IObject
    {
        private readonly Pen pen;
        private readonly GraphicsPath path;
 
        public Line(Pen pen, IList<Point> points, string option)
        {
            this.pen = pen;
            var convertedOption = PathPointType.Line; // TODO: convert from option
            var pointTypes = points.Select(_ => (byte)convertedOption).ToArray();
            this.path = new GraphicsPath(points.ToArray(), pointTypes);
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawPath(pen, path);
        }
    }
}