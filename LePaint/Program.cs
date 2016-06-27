using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LePaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new LePaintView();
            var model = new Canvas.Canvas();
            var canvasPresenter = new Canvas.CanvasPresenter(view, model);
            var filePresenter = new Files.FilePresenter(view);
            Application.Run(view);
        }
    }
}
