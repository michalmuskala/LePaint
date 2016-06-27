using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Files
{
    public class SaveRequestArgs
    {
        public string Filename;
        public int Width;
        public int Height;
    }

    public interface IFileView
    {
        event EventHandler<string> LoadRequested;
        event EventHandler<SaveRequestArgs> SaveRequested;

        void DumpToGraphics(Graphics graphics);
        void LoadBitmap(Bitmap bitmap);
    }
}
