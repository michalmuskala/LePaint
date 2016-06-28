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
        private string name;

        public FilePresenter(IFileView view, string name)
        {
            this.view = view;
            view.LoadRequested += OnLoadRequested;
            view.SaveRequested += OnSaveRequested;
            this.name = name;
            view.Text = name;
        }

        public FilePresenter(IFileView view) : this(view, "nowyObraz")
        {
        }

        private void OnSaveRequested(object sender, SaveRequestArgs e)
        {
            var bitmap = new Bitmap(e.Width, e.Height);
            view.DumpToGraphics(Graphics.FromImage(bitmap));
            if (e.Filename != null)
            {
                bitmap.Save(e.Filename);
            }
            else
            {
                bitmap.Save(name);
            }
        }

        private void OnLoadRequested(object sender, string e)
        {
            AppStarter.BitmapWindow(e);
        }
    }
}
