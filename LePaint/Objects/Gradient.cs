using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    class Gradient : IObject
    {
         protected Pen pen;
        private readonly GraphicsPath path;
       

        public Gradient(Pen pen, IList<Point> points)
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

                        points[i] = Point.Empty;
                    }
                    if (i % 3 == 0)
                    {
                        points[i] = new Point(points[i].X + 1, points[i].Y + 3);
                    }
                    if (i % 4 == 0)
                    {
                        points[i] = new Point(points[i].X + 2, points[i].Y + 4);
                    }
                    
                }
                Point[] tab;
                tab = points.ToArray();
              
                    this.path = new GraphicsPath(tab, pointTypes);

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
