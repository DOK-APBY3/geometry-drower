using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry_drower
{
    public abstract class GeometryPrimitive
    {

        public abstract List<PointClass> GetAllPoints(); // этот класс нужен для более безкостыльного создания универсальной рисолвалки

        public abstract PointClass getP1();

        public abstract void addX(int DelX);
        public abstract void addY(int DelY);
    }
}
