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
    // Interfejs modelu płótna
    public interface ICanvas
    {
        IEnumerable<IObject> Objects { get; }

        void RefreshTemporaryObjects(IBrush brush, IEnumerable<Point> path);
        void CommitTemporaryObjects();
    }
}
