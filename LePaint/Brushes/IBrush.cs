using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    public interface IBrush
    {
        bool Filled { set; }
        Pen Pen { set; }

        bool AffectedByPen { get; }
        bool AffectedByFilled { get; }

        IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path);
    }
}
