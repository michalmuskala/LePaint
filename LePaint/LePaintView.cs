using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LePaint
{
    public partial class LePaintView : Form
    {
       
        public LePaintView()
        {
            
            InitializeComponent();
            plotno1.PenColor = Color.Black;
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            
            ColorDialog dialog = new ColorDialog();
            dialog.Color = colorPicker.BackColor;
            dialog.ShowDialog();
            colorPicker.BackColor = dialog.Color;
            plotno1.PenColor = dialog.Color;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int rozmiar = e.NewValue;
            
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            plotno1.PenSize = Int32.Parse(penWidth.Text);
        }

        private void LePaintView_Resize(object sender, EventArgs e)
        {
            //trzeba obsluzyc zmiane rozmiaru / skalowanie plotna
        }
    }
}
