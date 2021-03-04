using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class Coordinate
    {
        private double x, y;

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX() { return x; }

        public void setX(double x) { this.x = x; }

        public double getY() { return y; }

        public void setY(double y) { this.y = y; }

    }
}
