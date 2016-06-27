using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Files
{
    public class FilePresenter
    {
        private IFileView view;

        public FilePresenter(IFileView view)
        {
            this.view = view;
            view.LoadRequested += OnLoadRequested;
            view.SaveRequested += OnSaveRequested;
        }

        private void OnSaveRequested(object sender, SaveRequestArgs e)
        {
            var bitmap = new Bitmap(e.Width, e.Height);
            view.DumpToGraphics(Graphics.FromImage(bitmap));
            bitmap.Save(e.Filename);
        }

        private void OnLoadRequested(object sender, string e)
        {
            var bitmap = new Bitmap(e);
            view.LoadBitmap(bitmap);
        }
    }
}
