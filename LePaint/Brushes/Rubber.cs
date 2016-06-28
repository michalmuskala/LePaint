using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Rubber : Line
    {
        public override IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            var pen = new Pen(Color.White, Pen.Width * 2);
            PathPointType option;
            Enum.TryParse<PathPointType>(Option, true, out option);
            yield return new Objects.Line(pen, path.ToList(), option);
        }
    }
}
