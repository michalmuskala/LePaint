using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Files
{
    // Prezenter odpowiedzialny za obsługę operacji na plikach
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

        private void OnSaveRequested(object sender, SaveRequestArgs args)
        {
            try {
                var bitmap = new Bitmap(args.Width, args.Height);
                view.DumpToGraphics(Graphics.FromImage(bitmap));
                if (args.Filename != null)
                {
                    Name = args.Filename;
                }
                bitmap.Save(name);
            }
            catch (Exception e)
            {
                view.ShowError(string.Format("Błąd zapisu pliku: {0}", e.Message));
            }
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
