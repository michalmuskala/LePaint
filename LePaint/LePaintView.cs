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
using LePaint.Files;

namespace LePaint
{
    public partial class LePaintView : Form, ICanvasView, IFileView
    {
        const string Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff";

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
            set {
                if (value)
                    checkBox1.Show();
                else
                    checkBox1.Hide();
            }
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
        public event EventHandler<string> LoadRequested;
        public event EventHandler<SaveRequestArgs> SaveRequested;
        public event EventHandler<bool> FilledChanged;

        public LePaintView(int canvasWidth, int canvasHeight)
        {
            InitializeComponent();
            DoubleBuffered = true;
            plotno1.PathUpdated = OnPathUpdated;
            plotno1.Commit = OnCommit;
            plotno1.MaximumSize = new System.Drawing.Size(canvasWidth, canvasHeight);
            plotno1.MinimumSize = new System.Drawing.Size(canvasWidth, canvasHeight);
            plotno1.Size = new System.Drawing.Size(canvasWidth, canvasHeight);
            Load += (sender, args) => OnBrushSelected("line");
        }
        public LePaintView() : this(1200, 650)
        {
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

        public void DumpToGraphics(Graphics graphics)
        {
            plotno1.DumpToGraphics(graphics);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            OnFilledChanged(checkbox.Checked);
        }

        private void OnFilledChanged(bool v)
        {
            var handlers = FilledChanged;
            if (handlers != null)
            {
                handlers(this, v);
            }
        }

        private void brush_Click(object sender, EventArgs e)
        {
            var box = sender as PictureBox;
            OnBrushSelected(box.Name.Replace("Brush", ""));
        }

        private void OnBrushSelected(string v)
        {
            var handlers = BrushSelected;
            if (handlers != null)
            {
                handlers(this, v);
            }
        }

        private void OnSaveRequested(string v)
        {
            var handlers = SaveRequested;
            if (handlers != null)
            {
                handlers(this, new SaveRequestArgs()
                {
                    Filename = v,
                    Width = plotno1.Width,
                    Height = plotno1.Height
                });
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = Filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OnLoadRequested(dialog.FileName);
            }
        }

        private void OnLoadRequested(string safeFileName)
        {
            var handlers = LoadRequested;
            if (handlers != null)
            {
                handlers(this, safeFileName);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSaveRequested(null);
        }

        public void ShowError(string v)
        {
            MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void zapiszJakoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = ".bmp";
            dialog.CreatePrompt = true;
            dialog.Filter = Filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OnSaveRequested(dialog.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
