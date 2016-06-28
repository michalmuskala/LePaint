using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    internal class Image : IObject
    {
        private readonly Bitmap bitmap;
        private readonly System.Drawing.Rectangle rectangle;

        public Image(Bitmap bitmap, Point point1, Point point2)
        {
            this.bitmap = bitmap;
            this.rectangle = GetRectangle(point1, point2);
        }

        private System.Drawing.Rectangle GetRectangle(Point point1, Point point2)
        {
            if (point1 != Point.Empty && point2 != Point.Empty)
            {
                var x = Math.Min(point1.X, point2.X);
                var y = Math.Min(point1.Y, point2.Y);
                var width = Math.Abs(point1.X - point2.X);
                var height = Math.Abs(point1.Y - point2.Y);
                return new System.Drawing.Rectangle(x, y, width, height);
            }
            else
            {
                return new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height);
            }
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(bitmap, rectangle);
        }
    }
}
