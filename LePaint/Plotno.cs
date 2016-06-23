using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LePaint
{
    public partial class Plotno : UserControl
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;
        Color penColor;
        public Plotno()
        {
            pen.Color = Color.Black;
            InitializeComponent();
        }

        public Color PenColor
        {
            get
            {
                return penColor;
            }
            set
            {
                penColor = value;
                pen.Color = value;
            }
        }
        public int PenSize
        {
            set
            {
                pen.Width = value;
            }
        }
        private void Plotno_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                k = 1;
            }
        }

        private void Plotno_MouseMove(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                ep = e.Location;
                graphics = this.CreateGraphics();
                graphics.DrawLine(pen, sp, ep);
                graphics.DrawLine(pen, sp, ep);

            }
            sp = ep;

            
        }

        private void Plotno_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }
    }
}
