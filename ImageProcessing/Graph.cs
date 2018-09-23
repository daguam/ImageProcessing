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
        List<Node> shortestPath;
        List<Point> animationList;
        List<Node> nearestNodes;
        Point animationPoint;
        int flag = 0;
        double minWeight = double.MaxValue;
        double possible;
        double arcWeight;
        double m, b;
        double x_c, x_i, x_f, x_aux;
        double y_c, y_i, y_f, y_aux;
        bool obstruction = false;
        bool reverse = false;
        double nearest = double.MaxValue;

        // Graph constructor method
        public Graph()
        {
            nodeList = new List<Node>();
            shortestPath = new List<Node>();
            animationList = new List<Point>();
            nearestNodes = new List<Node>();

        }

        // Access modifiers for graph atributes

        public List<Node> NodeList
        {
            get { return nodeList; }
        }

        public List<Node> ShortestPath
        {
            get { return shortestPath; }
        }

        public List<Node> NearestNodes
        {
            get { return nearestNodes; }
        }

        public double MinWeight
        {
            get { return minWeight; }
        }

        // Graph methods

        // Creates nodes from the list of points with circle centers
        public void InitializeGraph(List<Point> pointList, List<int> radiusList)
        {
            int i = 1;
            foreach (Point p in pointList)
            {
                Node n = new Node(p, i, radiusList[i-1]);
                nodeList.Add(n);
                i++;
            }
        }

        // Creates a graph that only joins nodes with no obstructions between them

        public void GraphWithObstruction(Bitmap img)
        {          
            using (var graphics = Graphics.FromImage(img))
            {
                foreach (Node origin in NodeList)
                {
                    foreach (Node destination in NodeList)
                    {
                        animationList.Clear();
                        x_i = origin.NodePoint.X;
                        x_f = destination.NodePoint.X;
                        y_i = origin.NodePoint.Y;
                        y_f = destination.NodePoint.Y;
                        flag = 0;
                        obstruction = false;
                        if (origin.NodeNum != destination.NodeNum)
                        {
                            m = (y_f - y_i) / (x_f - x_i);
                            b = y_i - (m * x_i);
                            if ((m > 1 || m < -1) && double.IsInfinity(m) == false)
                            {
                                reverse = false;
                                if (y_i > y_f)
                                {
                                    y_aux = y_i;
                                    y_i = y_f;
                                    y_f = y_aux;
                                    reverse = true;
                                }
                                for (y_c = y_i; y_c <= y_f; y_c++)
                                {
                                    x_c = (y_c - b) / m;
                                    animationPoint = new Point((int)x_c, (int)y_c);
                                    animationList.Add(animationPoint);
                                    if (flag == 0)
                                    {
                                        if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).R == 255)
                                            if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).G == 255)
                                                if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).B == 255)
                                                {
                                                    flag = 1;
                                                }
                                    }
                                    if (flag == 1)
                                    {
                                        if ((img.GetPixel((int)(Math.Round(x_c)), (int)y_c).R <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).R >= 250) &&
                                        (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).G <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).G >= 250) &&
                                        (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).B <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).B >= 250))
                                        {

                                        }
                                        else
                                        {
                                            flag = 2;
                                        }
                                        if ((img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).R <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).R >= 250) &&
                                        (img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).G <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).G >= 250) &&
                                        (img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).B <= 255) && (img.GetPixel((int)(Math.Round(x_c)), (int)y_c+1).B >= 250))
                                        {

                                        }
                                        else
                                        {
                                            flag = 2;
                                            y_c++;
                                        }
                                    }
                                    if (flag == 2)
                                    {
                                        if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).R == 255)
                                            if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).G == 255)
                                                if (img.GetPixel((int)(Math.Round(x_c)), (int)y_c).B == 255)
                                                {
                                                    obstruction = true;
                                                    break;
                                                }
                                    }
                                }
                                if (obstruction == false)
                                {
                                    arcWeight = Math.Sqrt(Math.Pow(x_i - x_f, 2) + Math.Pow(y_i - y_f, 2));
                                    Arc a = new Arc(destination, arcWeight);
                                    if (reverse == true)
                                    {
                                        animationList.Reverse();
                                    }
                                    a.CreateAnimationList(animationList);
                                    origin.InsertArc(a);
                                }
                            }
                            if (m <= 1 && m >= -1)
                            {
                                reverse = false;
                                if (x_i > x_f)
                                {
                                    x_aux = x_i;
                                    x_i = x_f;
                                    x_f = x_aux;
                                    reverse = true;
                                }
                                for (x_c = x_i; x_c <= x_f; x_c++)
                                {
                                    y_c = m * x_c + b;
                                    animationPoint = new Point((int)x_c, (int)y_c);
                                    animationList.Add(animationPoint);
                                    if (flag == 0)
                                    {
                                        if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).R == 255)
                                            if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).G == 255)
                                                if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).B == 255)
                                                {
                                                    flag = 1;
                                                }
                                    }
                                    if (flag == 1)
                                    {
                                        if ((img.GetPixel((int)x_c, (int)Math.Round(y_c)).R <= 255) && (img.GetPixel((int)x_c, (int)Math.Round(y_c)).R >= 250) &&
                                        (img.GetPixel((int)x_c, (int)Math.Round(y_c)).G <= 255) && (img.GetPixel((int)x_c, (int)Math.Round(y_c)).G >= 250) &&
                                        (img.GetPixel((int)x_c, (int)Math.Round(y_c)).B <= 255) && (img.GetPixel((int)x_c, (int)Math.Round(y_c)).B >= 250))
                                        {

                                        }
                                        else
                                        {
                                            flag = 2;
                                        }
                                        if (m > 0 || m < 0) 
                                        {
                                            if((img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).R <= 255) && (img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).R >= 250) &&
                                            (img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).G <= 255) && (img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).G >= 250) &&
                                            (img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).B <= 255) && (img.GetPixel((int)x_c + 1, (int)Math.Round(y_c)).B >= 250))
                                            {

                                            }
                                            else
                                            {
                                                flag = 2;
                                                x_c++;
                                            }
                                        }                                        
                                    }
                                    if (flag == 2)
                                    {
                                        {
                                            if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).R == 255)
                                                if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).G == 255)
                                                    if (img.GetPixel((int)x_c, (int)Math.Round(y_c)).B == 255)
                                                    {
                                                        obstruction = true;
                                                        break;
                                                    }
                                        }
                                    }
                                }
                                if (obstruction == false)
                                {
                                    arcWeight = Math.Sqrt(Math.Pow(x_i - x_f, 2) + Math.Pow(y_i - y_f, 2));
                                    if (reverse == true)
                                    {
                                        animationList.Reverse();
                                    }
                                    Arc a = new Arc(destination, arcWeight);
                                    a.CreateAnimationList(animationList);
                                    origin.InsertArc(a);
                                }

                            }
                            if (double.IsInfinity(m) == true)
                            {
                                reverse = false;
                                if (y_i > y_f)
                                {
                                    y_aux = y_i;
                                    y_i = y_f;
                                    y_f = y_aux;
                                    reverse = true;
                                }
                                for (y_c = y_i; y_c <= y_f; y_c++)
                                {
                                    x_c = x_i;
                                    animationPoint = new Point((int)x_c, (int)y_c);
                                    animationList.Add(animationPoint);
                                    if (flag == 0)
                                    {
                                        if (img.GetPixel((int)x_c, (int)(y_c)).R == 255)
                                            if (img.GetPixel((int)x_c, (int)(y_c)).G == 255)
                                                if (img.GetPixel((int)x_c, (int)(y_c)).B == 255)
                                                {
                                                    flag = 1;
                                                }
                                    }
                                    if (flag == 1)
                                    {
                                        if ((img.GetPixel((int)x_c, (int)(y_c)).R <= 255) && (img.GetPixel((int)x_c, (int)(y_c)).R >= 250) &&
                                        (img.GetPixel((int)x_c, (int)(y_c)).G <= 255) && (img.GetPixel((int)x_c, (int)(y_c)).G >= 250) &&
                                        (img.GetPixel((int)x_c, (int)(y_c)).B <= 255) && (img.GetPixel((int)x_c, (int)(y_c)).B >= 250))
                                        {
                                        }
                                        else
                                        {
                                            flag = 2;
                                        }
                                    }
                                    if (flag == 2)
                                    {
                                        {
                                            if (img.GetPixel((int)x_c, (int)(y_c)).R == 255)
                                                if (img.GetPixel((int)x_c, (int)(y_c)).G == 255)
                                                    if (img.GetPixel((int)x_c, (int)(y_c)).B == 255)
                                                    {
                                                        obstruction = true;
                                                        break;
                                                    }
                                        }
                                    }
                                }
                                if (obstruction == false)
                                {
                                    arcWeight = Math.Sqrt(Math.Pow(x_i - x_f, 2) + Math.Pow(y_i - y_f, 2));
                                    if (reverse == true)
                                    {
                                        animationList.Reverse();
                                    }
                                    Arc a = new Arc(destination, arcWeight);
                                    a.CreateAnimationList(animationList);
                                    origin.InsertArc(a);
                                }
                            }
                        }
                    }
                }
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

        // Brute force algorithm for shortest path that contains 4 nodes
        public void BruteForceShortest()
        {
            foreach (Node n in nodeList)
            {
                foreach (Arc a in n.ArcList)
                {
                    foreach (Arc a2 in a.ArcNode.ArcList)
                    {
                        foreach (Arc a3 in a2.ArcNode.ArcList)
                        {
                            if(n.NodeNum != a.ArcNode.NodeNum && n.NodeNum != a2.ArcNode.NodeNum && n.NodeNum != a3.ArcNode.NodeNum)
                            {
                                if (a.ArcNode.NodeNum != a2.ArcNode.NodeNum && a.ArcNode.NodeNum != a3.ArcNode.NodeNum)
                                {
                                    if (a2.ArcNode.NodeNum != a3.ArcNode.NodeNum)
                                    {
                                        possible = a.ArcWeight + a2.ArcWeight + a3.ArcWeight;
                                        if (possible < minWeight)
                                        {
                                            shortestPath.Clear();
                                            minWeight = possible;
                                            shortestPath.Add(n);
                                            shortestPath.Add(a.ArcNode);
                                            shortestPath.Add(a2.ArcNode);
                                            shortestPath.Add(a3.ArcNode);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void BruteForceNearest()
        {      
            foreach (Node n in nodeList)
            {
                foreach (Arc a in n.ArcList)
                {
                    if (a.ArcWeight < nearest)
                    {
                        nearestNodes.Clear();
                        nearest = a.ArcWeight;
                        nearestNodes.Add(n);
                        nearestNodes.Add(a.ArcNode);
                    }
                }
            }

        }
    }// End graph class

    public class Node
    {
        List<Arc> arcList;
        Point nodePoint;
        int nodeNum;
        int nodeRadius;

        // Node constructor method
        public Node (Point nodePoint, int nodeNum, int nodeRadius)
        {
            arcList = new List<Arc>();
            this.nodePoint = nodePoint;
            this.nodeNum = nodeNum;
            this.nodeRadius = nodeRadius;
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

        public int NodeRadius
        {
            get { return nodeRadius; }
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
        List<Point> animationList;

        // Arc constructor method
        public Arc(Node arcNode, double arcWeight)
        {
            this.arcNode = arcNode;
            this.arcWeight = arcWeight;
            this.animationList = new List<Point>();
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

        public List<Point> AnimationList
        {
            get { return animationList; }
        }

        // Arc methods

        // Generates the animation list
        public void CreateAnimationList (List<Point> pointList)
        {
            foreach (Point p in pointList)
            {
                animationList.Add(p);
            }
        }
    }

    public class Particle
    {
        Node particleNode;

        // Particle constructor
        public Particle (Node particleNode)
        {
            this.particleNode = particleNode;
        }

        // Access modifiers for Particle atributes

        public Node ParticleNode
        {
            get { return particleNode; }
            set { particleNode = value; }
        }
    }
}
