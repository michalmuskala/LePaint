using System;
using System.Drawing;

namespace LePaint.Objects
{
    internal class Rectangle : IObject
    {
        protected Pen pen;
        protected System.Drawing.Rectangle rectangle;
        protected bool filled;

        public Rectangle(Pen pen, bool filled, Point point1, Point point2, bool regular)
        {
            this.filled = filled;
            this.pen = pen;
            var x = Math.Min(point1.X, point2.X);
            var y = Math.Min(point1.Y, point2.Y);
            var width = Math.Abs(point1.X - point2.X);
            var height = Math.Abs(point1.Y - point2.Y);
            if (regular)
                width = height = Math.Min(width, height);
            this.rectangle = new System.Drawing.Rectangle(x, y, width, height);
        }

        public virtual void Draw(Graphics graphics)
        {
            if (filled)
                graphics.FillRectangle(pen.Brush, rectangle);
            else
                graphics.DrawRectangle(pen, rectangle);
        }
    }
}