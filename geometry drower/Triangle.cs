using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry_drower
{
    class Triangle
    {
        private PointClass point1, point2, point3;

        public Triangle(PointClass point1, PointClass point2, PointClass point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public void move(int DelX, int DelY)
        {
            movePoint(point1, DelX, DelY);
            movePoint(point2, DelX, DelY);
            movePoint(point3, DelX, DelY);
        }

        private void movePoint(PointClass point, int Dx, int Dy)
        {
            point.addXP(Dx);
            point.addYP(Dy);
        }

    }
}
