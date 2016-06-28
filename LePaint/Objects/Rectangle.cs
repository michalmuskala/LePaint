using System;
using System.Drawing;

namespace LePaint.Objects
{
    internal class Rectangle : IObject
    {
        private Pen pen;
        private System.Drawing.Rectangle rectangle;
        private bool filled;

        public Rectangle(Pen pen, bool filled, Point point1, Point point2)
        {
            this.filled = filled;
            this.pen = pen;
            var x = Math.Min(point1.X, point2.X);
            var y = Math.Min(point1.Y, point2.Y);
            var width = Math.Abs(point1.X - point2.X);
            var height = Math.Abs(point1.Y - point2.Y);
            this.rectangle = new System.Drawing.Rectangle(x, y, width, height);
        }

        public void Draw(Graphics graphics)
        {
            if (filled)
                graphics.FillRectangle(pen.Brush, rectangle);
            else
                graphics.DrawRectangle(pen, rectangle);
        }
    }
}