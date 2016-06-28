using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LePaint.Brushes;
using LePaint.Objects;

namespace LePaint.Canvas
{
    // Model półtna
    class Canvas : ICanvas
    {
        private IEnumerable<IObject> temporaryObjects = new List<IObject>(); //tymczasowo rysowane
        private List<IObject> objects = new List<IObject>(); //lista gotowych obiektow

        public IEnumerable<IObject> Objects
        {
            get {
                var list = new List<IObject>(objects);
                list.AddRange(temporaryObjects);
                return list;
            }
        }

        public void CommitTemporaryObjects()
        {
            objects.AddRange(temporaryObjects);
            temporaryObjects = new List<IObject>();
        }

        public void RefreshTemporaryObjects(IBrush brush, IEnumerable<Point> path)
        {
            temporaryObjects = brush.GenerateObjects(path);
        }
    }
}
