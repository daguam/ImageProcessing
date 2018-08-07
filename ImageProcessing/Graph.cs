using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    public class Graph
    {
        List<Node> nodeList;

        // Graph constructor method
        public Graph()
        {
            nodeList = new List<Node>();
        }

        // Access modifiers for graph atributes

        public List<Node> NodeList
        {
            get { return nodeList; }
        }

        // Graph methods

        // Creates nodes from the list of points with circle centers
        public void InitializeGraph(List<Point> pointList)
        {
            int i = 1;
            foreach (Point p in pointList)
            {
                Node n = new Node(p, i);
                nodeList.Add(n);
                i++;
            }
        }

        // Creates a complete graph from the initialized graph's nodeList
        public void CompleteGraph()
        {
            foreach (Node origin in nodeList)
            {
                foreach (Node destination in nodeList)
                {
                    if (origin != destination)
                    {
                        double arcWeight = Math.Sqrt(Math.Pow(origin.NodePoint.X - destination.NodePoint.X,2) + Math.Pow(origin.NodePoint.Y - destination.NodePoint.Y,2));
                        Arc a = new Arc(destination, arcWeight);
                        origin.InsertArc(a);

                    }
                }
            }
        }

        // Brute force algorithm for shortest path
    }
    public class Node
    {
        List<Arc> arcList;
        Point nodePoint;
        int nodeNum;

        // Node constructor method
        public Node (Point nodePoint, int nodeNum)
        {
            arcList = new List<Arc>();
            this.nodePoint = nodePoint;
            this.nodeNum = nodeNum;
        }

        // Access modifiers for node atributes

        public List<Arc> ArcList
        {
            get { return arcList; }
        }

        public Point NodePoint
        {
            get { return nodePoint; }
        }

        public int NodeNum
        {
            get { return nodeNum; }
        }

        // Node methods

        // Adds arcs to the node's arcList
        public void InsertArc(Arc arc)
        {
            arcList.Add(arc);
        }

        // Returns the int value as a string
        public override string ToString()
        {
            return nodeNum.ToString();
        }

    }
    public class Arc
    {
        Node arcNode;
        double arcWeight;

        // Arc constructor method
        public Arc(Node arcNode, double arcWeight)
        {
            this.arcNode = arcNode;
            this.arcWeight = arcWeight;
        }

        // Access modifiers for Arc atributes
        public Node ArcNode
        {
            get { return arcNode; }
        }

        public double ArcWeight
        {
            get { return arcWeight; }
        }
    }
}
