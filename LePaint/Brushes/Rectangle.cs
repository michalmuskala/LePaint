using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Rectangle : IBrush
    {
        public bool AffectedByPen { get { return true; } }
        public bool AffectedByFilled { get { return true; } }
        public IEnumerable<string> Options { get { return new List<string>(); } }

        public bool Filled { set; private get; }
        public Pen Pen { set; private get; }
        public string Option { set; private get; }

        public IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            if (path.Count() != 0)
                yield return new Objects.Rectangle(Pen, Filled, path.First(), path.Last());
        }
    }
}
