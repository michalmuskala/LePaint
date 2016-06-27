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
                if (value == true)
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

        public void DumpToGraphics(Graphics graphics)
        {
            plotno1.DumpToGraphics(graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int newWidth = 500;
            //plotno1.MaximumSize = new Size(newWidth, plotno1.Height);
            //plotno1.Size = new Size(newWidth, plotno1.Height);
            plotno1.SuspendLayout();
            
            int tempWidth = Int32.Parse(textBox1.Text);
            int tempHeight = Int32.Parse(textBox2.Text);
            if ((tempWidth > 100 && tempHeight > 100) && (tempHeight < 2000 && tempWidth < 2000))
            {
                //Plotno plotno1 = new Plotno();
                plotno1.Width = tempWidth;
                plotno1.Height = tempHeight;
                plotno1.Size = new Size(tempWidth, plotno1.Height);
                
                plotno1.ResumeLayout(true);
                plotno1.PerformLayout();
            }
            
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowFilledSelector = checkBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelectedColor(Color.White);
            OnSelectedSize(10);
            OnCommit();
        }

        public void LoadBitmap(Bitmap bitmap)
        {
            throw new NotImplementedException();
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSaveRequested(@"C:\Users\Michal\Desktop\test.bmp");
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
            String openedFilePath;
            String fileName;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                if (fileName.Remove(0, (fileName.LastIndexOf(".") + 1)) != "jpg" && fileName.Remove(0, (fileName.LastIndexOf(".") + 1)) != "png" && fileName.Remove(0, (fileName.LastIndexOf(".") + 1)) != "bmp")
                {
                    MessageBox.Show(fileName.Remove(0, (fileName.LastIndexOf(".")+1)));
                }
                openedFilePath = dialog.SafeFileName;
            }
            
        }
    }
}
