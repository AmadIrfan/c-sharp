using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    internal class Boundary
    {
        private point topleft;
        private point topright;
        private point bottomleft;
        private point bottomright;

        public Boundary()
        {
            topleft = new point(0, 0);
            topright = new point(0, 90);
            bottomleft = new point(90, 0);
            bottomright = new point(90, 90);

        }
        public Boundary(point topleft, point topright, point bottomleft, point bottomright)
        {
            this.topleft = topleft;
            this.topright = topright;
            this.bottomleft = bottomleft;
            this.bottomright = bottomright;
        }

        public point getPointTopLeft()
        {
            return topleft;
        }
        public point getPointTopRight()
        {
            return topright;
        }
        public point getPointBottomLeft()
        {
            return bottomleft;
        }
        public point getPointBottomRight()
        {
            return bottomright;
        }
    }
}
