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
using System.Drawing.Drawing2D;

namespace LePaint
{
    // Komponent odpowiedzialny za wyświetlanie i obsługę pola rysowania
    public partial class Plotno : UserControl
    {
        // Co ile ruchów myszki odrysowanie kształtów
        private const int throtlingFactor = 5;

        private IList<Point> path = new List<Point>();
        private IEnumerable<IObject> nextObjects = new List<IObject>();
        private BufferedGraphics buffer;
        private bool mouseDown = false;
        private int throtleCounter = 0;

        public Action<IEnumerable<Point>> PathUpdated;
        public Action Commit;

        public IEnumerable<IObject> NextObjects
        {
            set
            {
                nextObjects = value;
                Redraw();
                Refresh();
            }
        }
         
        public Plotno()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            buffer = currentContext.Allocate(CreateGraphics(), DisplayRectangle);
            buffer.Graphics.Clear(Color.White);
            buffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        #region callbacks

        private void Plotno_MouseDown(object sender, MouseEventArgs e)
        {
            path.Add(e.Location);
            mouseDown = true;
        }
        private void Plotno_MouseUp(object sender, MouseEventArgs e)
        {
            RefreshBuffer(path, true);
            path = new List<Point>();
            mouseDown = false;
        }

        private void Plotno_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
            {
                return;
            }

            path.Add(e.Location);

            if (throtleCounter > throtlingFactor)
            {
                RefreshBuffer(path);
                throtleCounter = 0;
            }
            else
            {
                throtleCounter++;
            }
        }

        private void Plotno_Paint(object sender, PaintEventArgs e)
        {
            buffer.Render(e.Graphics);
        }

        #endregion

        private void RefreshBuffer(IList<Point> path, bool commit = false)
        {
            PathUpdated(path);
            if (commit)
            {
                Commit();
            }
        }

        private void Redraw()
        {
            buffer.Graphics.Clear(Color.White);
            foreach (var ob in nextObjects)
            {
                ob.Draw(buffer.Graphics);
            }
        }

        internal void DumpToGraphics(Graphics graphics)
        {
            buffer.Render(graphics);
        }
    }
}
