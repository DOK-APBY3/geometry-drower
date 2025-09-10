using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace geometry_drower
{
    internal class PointClass
    {
        private int X, Y;//переим

        public PointClass(int x, int y)
        {

            X = x;
            Y = y;
        }

        public void addXP(int x)
        {
            this.X += x;

        }

        public void addYP(int y)
        {
            this.Y += y;

        }

        public int getX()
        {
            return this.X;
        }

        public int getY()
        {
            return this.Y;
        }



        //hjkhjh
    }
}
