using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry_drower
{
    class Square
    {
        private PointClass Point1, Point2, Point3, Point4;

        public Square(PointClass point1, PointClass point2, PointClass point3, PointClass point4)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
            this.Point4 = point4;
        }

        public void addX(int DelX)
        {
            Point1.addXP(DelX);
            Point2.addXP(DelX);
            Point3.addXP(DelX);
            Point4.addXP(DelX);
        }
        public void addY(int DelY)
        {
            Point1.addYP(DelY);
            Point2.addYP(DelY);
            Point3.addYP(DelY);
            Point4.addYP(DelY);
        }


        

        public void move(int DelX, int DelY)
        {
            movePoint(Point1, DelX, DelY);
            movePoint(Point2, DelX, DelY);
            movePoint(Point3, DelX, DelY);
            movePoint(Point4, DelX, DelY);
        }

        private void movePoint(PointClass point, int Dx, int Dy)
        {
            point.addXP(Dx);
            point.addYP(Dy);
        }
    }
}
