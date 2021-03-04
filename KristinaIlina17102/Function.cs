using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class Function
    {
        private List<Coordinate> coordinateList;
    
        public Function() { }
        public Function(List<Coordinate> coordinateList)
        {
            this.coordinateList = coordinateList;
        }       
        public List<Coordinate> getCoordinateList() { return coordinateList; }

        public void setCoordinateList(List<Coordinate> coordinateList)
        {
            this.coordinateList = coordinateList;
        }    
    }
}
