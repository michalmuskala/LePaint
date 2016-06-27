﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    class Image : IObject
    {
        private readonly Bitmap bitmap;

        Image(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }
    }
}