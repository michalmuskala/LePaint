using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    // Interfejs obiektów, które potrafią się odrysować
    public interface IObject
    {
        void Draw(Graphics graphics);
    }
}
