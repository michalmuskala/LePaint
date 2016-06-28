using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Polygon : IBrush
    {
        public bool AffectedByPen { get { return true; } }
        public bool AffectedByFilled { get { return true; } }
        public IEnumerable<string> Options { get { return new string[] { }; } }
        public bool NeedsFile { get { return false; } }

        public bool Filled { set; protected get; }
        public Pen Pen { set; protected get; }
        public string Option { set; protected get; }
        public string Filename { set { return; } }

        public virtual IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            yield return new Objects.Polygon(Pen, Filled, path);
        }
    }
}
