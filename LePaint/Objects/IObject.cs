using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePaint.Objects
{
    public interface IObject
    {
        void Draw(Graphics graphics);
    }
}
