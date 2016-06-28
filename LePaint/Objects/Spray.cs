using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    internal class Spray : IObject
    {
        protected Pen pen;
        private readonly GraphicsPath path;
       

        public Spray(Pen pen, IList<Point> points)
        {
            if (points.Count == 0)
            {
                this.path = null;
            }
            else
            {
                this.pen = pen;
                var convertedOption = PathPointType.Line; // TODO: convert from option
                var pointTypes = points.Select(_ => (byte)convertedOption).ToArray();
                for (int i = 0; i < points.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        points[i] = new Point(0,0);
                    }
                }
                    this.path = new GraphicsPath(points.ToArray(), pointTypes);
                
                this.pen.Color = Color.Blue;
            }
        }

        public virtual void Draw(Graphics graphics)
        {
            if (path != null)
            {
                graphics.DrawPath(pen, path);
            }
        }
    }
}
