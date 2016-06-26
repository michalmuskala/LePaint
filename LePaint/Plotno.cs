using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LePaint.Objects;

namespace LePaint
{
    public partial class Plotno : UserControl
    {
        private const int throtlingFactor = 2;

        private IList<Point> path = new List<Point>();
        private IEnumerable<IObject> nextObjects = new List<IObject>();
        private Graphics graphics;
        private bool mouseDown = false;
        private int throtleCounter = 0;

        public Action<IEnumerable<Point>> PathUpdated;
        public Action Commit;

        public IEnumerable<IObject> NextObjects
        {
            set
            {
                nextObjects = value;
                Refresh();
            }
        }

        public Plotno()
        {
            InitializeComponent();
            this.graphics = CreateGraphics();
        }

        private void Plotno_MouseDown(object sender, MouseEventArgs e)
        {
            path.Add(e.Location);
            mouseDown = true;
        }
        private void Plotno_MouseUp(object sender, MouseEventArgs e)
        {
            PathUpdated(path);
            Commit();
            path = new List<Point>();
            mouseDown = false;
        }

        private void Plotno_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
            {
                return;
            }

            if (throtleCounter > throtlingFactor)
            {
                path.Add(e.Location);
                PathUpdated(path);
                throtleCounter = 0;
            }
            else
            {
                throtleCounter++;
            }
        }

        private void Plotno_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ob in nextObjects)
            {
                ob.Draw(graphics);
            }
        }
    }
}
