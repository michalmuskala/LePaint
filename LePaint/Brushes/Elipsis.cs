using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    class Elipsis : Rectangle
    {
        public override IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path)
        {
            if (path.Count() != 0)
                yield return new Objects.Elipsis(Pen, Filled, path.First(), path.Last(), Option == "Regularny");
        }
    }
}
