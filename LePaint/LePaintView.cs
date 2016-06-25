using LePaint.Canvas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LePaint.Brushes;
using LePaint.Objects;

namespace LePaint
{
    public partial class LePaintView : Form, ICanvasView
    {
        public IEnumerable<IObject> NextObjects
        {
            set { plotno1.NextObjects = value; }
        }

        public bool ShowColorAndSizeSelectors 
        {
            set { /* show/hide selectors */ }
        }

        public bool ShowFilledSelector
        {
            set { /* show fide the checkbox */ }
        }

        public event EventHandler<IEnumerable<Point>> PathUpdated;
        public event EventHandler<string> BrushSelected;
        public event EventHandler<Color> SelectedColor;
        public event EventHandler<int> SelectedSize;
        public event EventHandler Commit;

        public LePaintView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            plotno1.PathUpdated = path => PathUpdated?.Invoke(this, path);
            plotno1.Commit = () => Commit?.Invoke(this, new EventArgs());
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = colorPicker.BackColor;
            dialog.ShowDialog();
            colorPicker.BackColor = dialog.Color;
            SelectedColor?.Invoke(this, dialog.Color);
            Commit?.Invoke(this, new EventArgs());
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int rozmiar = e.NewValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSize?.Invoke(this, Int32.Parse(penWidth.Text));
            Commit?.Invoke(this, new EventArgs());
        }

        private void LePaintView_Resize(object sender, EventArgs e)
        {
            //trzeba obsluzyc zmiane rozmiaru / skalowanie plotna
        }
    }
}
