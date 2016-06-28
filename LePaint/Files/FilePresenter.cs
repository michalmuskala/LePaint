using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Files
{
    public class FilePresenter
    {
        private IFileView view;
        private string name;

        private string Name
        {
            set { this.name = value; view.Text = value; }
        }

        public FilePresenter(IFileView view, string name)
        {
            this.view = view;
            view.LoadRequested += OnLoadRequested;
            view.SaveRequested += OnSaveRequested;
            Name = name;
        }

        public FilePresenter(IFileView view) : this(view, DefaultName())
        {
        }

        private void OnSaveRequested(object sender, SaveRequestArgs e)
        {
            var bitmap = new Bitmap(e.Width, e.Height);
            view.DumpToGraphics(Graphics.FromImage(bitmap));
            if (e.Filename != null)
            {
                Name = e.Filename;
            }
            bitmap.Save(name);
        }

        private static string DefaultName()
        {
            var path = Directory.GetCurrentDirectory();
            return Path.Combine(path, "bezNazwy.bmp");
        }

        private void OnLoadRequested(object sender, string e)
        {
            AppStarter.BitmapWindow(e);
        }
    }
}
