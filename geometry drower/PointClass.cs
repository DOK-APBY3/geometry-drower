using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace geometry_drower
{
    class PointClass
    {
        private int X, Y;//переим

        public PointClass(int x, int y)
        {

            X = x;
            Y = y;
        }

        public void addXP(int x)
        {
            X += x;

        }

        public void addYP(int y)
        {
            Y += y;

        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }



        //hjkhjh
    }
}
