using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsOf2D.Data.BL
{
    class Boundary
    {
        public int TopLeft;
        public int TopRight;
        public int BottomLeft;
        public int BottomRight;
        public Boundary()
        {

        }
        public Boundary(int TopLeft, int TopRight,int BottomLeft,int BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
    }
}
