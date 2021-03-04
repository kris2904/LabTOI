using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class Pixels
    {
        private Coordinate coordinate;
        private int color;

        public Pixels(Coordinate coordinate, int color) {
            this.coordinate = coordinate;
            this.color = color;
        }

        public int getColor() { return color; }

        public void setColor(int color)
        {
            this.color = color;
        }

        public Coordinate getCoordinate() { return coordinate; }

        public void setCoordinate(Coordinate coordinate)
        {
            this.coordinate = coordinate;
        }
    }
}
