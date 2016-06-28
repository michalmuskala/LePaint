using LePaint.Brushes;
using LePaint.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Canvas
{
    public interface ICanvasView
    {
        event EventHandler<IEnumerable<Point>> PathUpdated;
        event EventHandler<string> BrushSelected;
        event EventHandler<Color> SelectedColor;
        event EventHandler<int> SelectedSize;
        event EventHandler<string> OptionSelected;
        event EventHandler<bool> FilledChanged;
        event EventHandler Commit;

        IEnumerable<IObject> NextObjects { set; }
        IEnumerable<string> BrushOptions { set; }
        bool ShowColorAndSizeSelectors { set; }
        bool ShowFilledSelector { set; }
    }
}
