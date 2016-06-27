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

        public IEnumerable<string> BrushOptions
        {
            set
            {
                /* a combobox with those options */
            }
        }

        public event EventHandler<IEnumerable<Point>> PathUpdated;
        public event EventHandler<string> BrushSelected; // Call when brush selected
        public event EventHandler<Color> SelectedColor;
        public event EventHandler<int> SelectedSize;
        public event EventHandler<string> OptionSelected; // Call on option selection
        public event EventHandler Commit; // event zapisu temporaryObject do Object

        public LePaintView()
        {
            InitializeComponent();
            DoubleBuffered = true; 
            plotno1.PathUpdated = OnPathUpdated;
            plotno1.Commit = OnCommit;
        }

        private void OnCommit()
        {
            var handlers = Commit;
            if (handlers != null)
            {
                handlers(this, new EventArgs());
            }
        }

        private void OnPathUpdated(IEnumerable<Point> obj)
        {
            var handlers = PathUpdated;
            if (handlers != null)
            {
                handlers(this, obj);
            }
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = colorPicker.BackColor;
            dialog.ShowDialog();
            colorPicker.BackColor = dialog.Color;
            OnSelectedColor(dialog.Color);
            OnCommit();
        }

        private void OnSelectedColor(Color color)
        {
            var handlers = SelectedColor;
            if (handlers != null)
            {
                handlers(this, color);
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedSize(Int32.Parse(penWidth.Text));
            OnCommit();
        }

        private void OnSelectedSize(int v)
        {
            var handlers = SelectedSize;
            if (handlers != null)
            {
                handlers(this, v);
            }
        }

        private void LePaintView_Resize(object sender, EventArgs e)
        {
            //trzeba obsluzyc zmiane rozmiaru / skalowanie plotna
        }

        private void LePaintView_Load(object sender, EventArgs e)
        {

        }

        private void plotno1_Load(object sender, EventArgs e)
        {

        }

        private void plotno1_Load_1(object sender, EventArgs e)
        {

        }

        private void plotno1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
