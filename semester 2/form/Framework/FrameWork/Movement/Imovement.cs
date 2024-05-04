using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FrameWork.Movement
{
    public interface Imovement
    {
        Point move(Point location);
    }
}
