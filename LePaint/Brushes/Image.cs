using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Image : IBrush
    {
        public bool AffectedByPen { get { return false; } }
        public bool AffectedByFilled { get { return false; } }
        // Take options fro GraphicsPoint
        public IEnumerable<string> Options { get { return new List<string>(); } }
        public bool NeedsFile { get { return bmp == null; } }

        public bool Filled { set { return; } }
        public Pen Pen { set { return; } }
        public string Option { set { return; } }
        public string Filename
        {
            set
            {
                var image = System.Drawing.Image.FromFile(value);
                bmp = new Bitmap(image);
                image.Dispose();
            }
        }

        private Bitmap bmp;

        public Image(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public Image()
        {
            this.bmp = null;
        }

        public IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            yield return new Objects.Image(bmp, path.FirstOrDefault(), path.LastOrDefault());
        }

        private Bitmap RequestBmp()
        {
            throw new NotImplementedException();
        }
    }
}
