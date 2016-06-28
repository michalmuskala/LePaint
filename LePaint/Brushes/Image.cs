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

        public bool Filled { set { return; } }
        public Pen Pen { set { return; } }
        public string Option { set { return; } }

        private Bitmap bmp;

        public Image(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            yield return new Objects.Image(bmp);
        }
    }
}
