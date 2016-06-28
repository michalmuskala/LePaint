using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LePaint.Objects;
using System.Drawing.Drawing2D;

namespace LePaint.Brushes
{
    class Line : IBrush
    {
        public bool AffectedByPen { get { return true; } }
        public bool AffectedByFilled { get { return false; } }
        public IEnumerable<string> Options
        {
            get
            {
                var options = new List<string>();
                options.Add("Line");
                options.Add("Bezier");
                return options;
            }
        }
        public bool NeedsFile { get { return false; } }

        public bool Filled { set { return; } }
        public Pen Pen { set; protected get; }
        public string Option { set; protected get; }
        public string Filename { set { return; } }

        public virtual IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            PathPointType option;
            Enum.TryParse<PathPointType>(Option, true, out option);
            yield return new Objects.Line(Pen, path.ToList(), option);
        }
    }
}
