using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Rubber : IBrush
    {
        public bool AffectedByPen { get { return true; } }
        public bool AffectedByFilled { get { return false; } }
        // Take options fro GraphicsPoint
        public IEnumerable<string> Options { get { return new List<string>(); } }

        public bool Filled { set { return; } }
        public Pen Pen { set; private get; }
        public string Option { set; private get; }

        public IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            var pen = new Pen(Color.White, Pen.Width * 2);
            yield return new Objects.Line(pen, path.ToList(), Option);
        }
    }
}
