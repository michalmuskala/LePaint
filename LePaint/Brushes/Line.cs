using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LePaint.Objects;

namespace LePaint.Brushes
{
    class Line : IBrush
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
            yield return new Objects.Line(Pen, path.ToList(), Option);
        }
    }
}
