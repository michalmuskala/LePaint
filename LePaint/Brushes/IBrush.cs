using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Brushes
{
    // Interfejs fabryki obiektów o interfejsie IObject wykorzystywany przez
    // presenter do obsługi różnych opcji, różnych narządzi.
    public interface IBrush
    {
        bool Filled { set; }
        Pen Pen { set; }
        string Option { set; }
        string Filename { set; }

        bool AffectedByPen { get; }
        bool AffectedByFilled { get; }
        IEnumerable<string> Options { get; }
        bool NeedsFile { get; }

        IEnumerable<IObject> GenerateObjects(IEnumerable<Point> path);
    }
}
