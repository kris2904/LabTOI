using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class WaveletMatrix
    {
        private List<Node> nodeList;

        public WaveletMatrix(){}

        public List<Node> getNodeList() { return nodeList; }

        public void setNodeList(List<Node> nodeList)
        {
            this.nodeList = nodeList;
        }

        public double getMinNode(List<Node> nodeList)
        {
            double min = 0;
            foreach (Node node in nodeList)
            {
                if (node.getValue() < min)
                {
                    min = node.getValue();
                }
            }
            return min;
        }

        public double getMaxNode(List<Node> nodeList)
        {
            double max = 0;
            foreach (Node node in nodeList)
            {
                if (node.getValue() > max)
                {
                    max = node.getValue();
                }
            }
            return max;
        }
    }
}
