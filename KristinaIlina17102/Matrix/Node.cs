using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class Node
    {
        private Coordinate coordinate;

        private double value;

        public Node(Coordinate coordinate, double value)
        {
            this.coordinate = coordinate;
            this.value = value;
        }

        public Coordinate getCoordinate() { return coordinate; }

        public void setCoordinate(Coordinate coordinate) { this.coordinate = coordinate; }

        public double getValue() { return value; }

        public void setValue(double value) { this.value = value; }
    }
}
