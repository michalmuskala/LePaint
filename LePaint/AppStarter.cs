using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LePaint
{
    public static class AppStarter
    {
        public static void InitialWindow()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(EmptyWindow());
        }

        public static void NewWindow()
        {
            var view = EmptyWindow();
            view.Show();
        }

        private static LePaintView EmptyWindow()
        {
            var view = new LePaintView();
            var model = new Canvas.Canvas();
            var canvasPresenter = new Canvas.CanvasPresenter(view, model);
            var filePresenter = new Files.FilePresenter(view);
            return view;
        }

        public static void BitmapWindow(string imageName)
        {
            try
            {
                var image = Image.FromFile(imageName);
                var bitmap = new Bitmap(image);
                var view = new LePaintView(image.Width, image.Height);
                var model = new Canvas.Canvas();
                var canvasPresenter = new Canvas.CanvasPresenter(view, model, bitmap);
                var filePresenter = new Files.FilePresenter(view, imageName);
                image.Dispose();
                view.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Błąd otwierania pliku: {0}", e.Message));
            }

        }
    }
}
