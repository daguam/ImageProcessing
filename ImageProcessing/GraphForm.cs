using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ImageProcessing
{
    public partial class GraphForm : Form
    {
        Graph graph;
        bool flag = false;
        Boolean drag;
        Boolean fail;   // Flag used to prevent opening the form when failing to process image
        Boolean shortestFlag = false;   // Flag used to prevent redraw for shortest path
        int mouseX;
        int mouseY;
        int xDisplacement = 0, yDisplacement = 0;
        double wF, hF, rF;
        Bitmap imgGraph, imgFront;
        List<Point> pointList;
        List<int> radiusList;
        Font drawFont = new Font("Ebrima", 16, FontStyle.Bold);
        Pen transparentPen = new Pen(Color.FromArgb (120, 138, 43, 223), 10);
        Node moveNode = null;

        // Window constructor
        public GraphForm(Bitmap img)
        {
            this.graph = new Graph();
            this.imgGraph = new Bitmap(img);
            this.pointList = new List<Point>();
            this.radiusList = new List<int>();
            this.imgFront = new Bitmap(imgGraph.Width, imgGraph.Height);
            InitializeComponent();
            wF = (double)img.Width / pictureBoxGraph.Width;
            hF = (double)img.Height / pictureBoxGraph.Height;
            if (wF > hF)
            {
                rF = wF;
                yDisplacement = (int)(pictureBoxGraph.Height - (img.Height / rF)) / 2;
            }
            else
            {
                rF = hF;
                xDisplacement = (int)(pictureBoxGraph.Width - (img.Width / rF)) / 2;
            }
            int i = 0;  // index for treeView component
            FindCirclesCenters findCC = new FindCirclesCenters(img, pointList, radiusList);
            try
            {
                findCC.FindCircle();
            }
            catch (ArgumentOutOfRangeException) // Failed to process image
            {
                fail = true;
                CustomMsgBoxForm msgBoxWindow = new CustomMsgBoxForm();
                DialogResult result = msgBoxWindow.Show("Failed to process image!");
                if (result == DialogResult.OK)
                {
                    msgBoxWindow.Close();
                }
            }
            graph.InitializeGraph(pointList, radiusList);
            graph.GraphWithObstruction(img);
            using (var graphics = Graphics.FromImage(imgGraph)) // Draws graph
            {
                foreach (Node n in graph.NodeList)
                {
                    foreach (Arc a in n.ArcList)
                    {
                        graphics.DrawLine(Pens.Black, n.NodePoint, a.ArcNode.NodePoint);
                    }
                }
                foreach (Node n in graph.NodeList)
                {
                    int recenter = 15;  // Adjust string position
                    Point centerPoint = new Point(n.NodePoint.X - recenter, n.NodePoint.Y - recenter);
                    graphics.DrawString(n.NodeNum.ToString(), drawFont, Brushes.White, centerPoint);
                }
            }
            pictureBoxGraph.BackgroundImage = imgGraph;
            pictureBoxGraph.Image = imgFront;
            foreach (Node n in graph.NodeList)  // Adds nodes and arcs to treeView component
            {
                treeViewGraph.Nodes.Add("Node " + n.ToString());
                foreach (Arc a in n.ArcList)
                {
                    treeViewGraph.Nodes[i].Nodes.Add("Arc " + a.ArcNode.ToString() + "  (Weight:\t" + a.ArcWeight.ToString() + ")");
                }
                i++;
            }
        }
        // End of constructor

        // Access modifiers for GraphForm atributes

        public Boolean Fail
        {
            get { return fail; }
        }

        // GraphForm methods

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);     // Draws borders
        }

        // Drag Window
        private void panelWindow_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }

        private void panelWindow_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            flag = false;
            shortestFlag = false;
            labelShortestPath.Visible = false;
            labelShortestPath.ResetText();
            labelShortestPath.Text = "Shortest path weight: ";
            using (var graphics = Graphics.FromImage(imgFront))
            {
                graphics.Clear(Color.Transparent);
                pictureBoxGraph.Refresh();
            }
        }

        private void pictureBoxGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Node found = null;
            double graphImgX;
            double graphImgY;
            graphImgX = (e.X - xDisplacement) * rF;
            graphImgY = (e.Y - yDisplacement) * rF;
            foreach (Node n in graph.NodeList)
            {
                Point nodePoint = n.NodePoint;
                if ((int)graphImgX > nodePoint.X - n.NodeRadius && (int)graphImgX < nodePoint.X + n.NodeRadius)
                {
                    if ((int)graphImgY > nodePoint.Y - n.NodeRadius && (int)graphImgY < nodePoint.Y + n.NodeRadius)
                    {
                        found = n;
                    }
                }
            }
            if (found != null)
            {
                Particle particle = new Particle(found);
                if (!flag)
                {
                    moveNode = found;
                    using (var graphics = Graphics.FromImage(imgFront))
                    {
                        graphics.FillEllipse(Brushes.LightBlue, found.NodePoint.X - 10, found.NodePoint.Y - 10, 15, 15);
                        pictureBoxGraph.Refresh();
                    }
                    flag = true;
                }
                if(flag)
                {
                    foreach (Arc a in moveNode.ArcList)
                    {
                        if (a.ArcNode == found)
                        {
                            using (var graphics = Graphics.FromImage(imgFront))
                            {
                                foreach (Point p in a.AnimationList)
                                {
                                    graphics.Clear(Color.Transparent);
                                    graphics.FillEllipse(Brushes.LightBlue, p.X - 10, p.Y - 10, 15, 15);
                                    pictureBoxGraph.Refresh();
                                }
                            }
                            moveNode = found;
                        }
                    }
                }
            }
        }

        // Minimize window
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ShortestPath call and draw
        private void buttonShortest_Click(object sender, EventArgs e)
        {
            if (shortestFlag == false)
            {
                graph.BruteForceShortest();
                if (graph.ShortestPath.Count > 3)
                {
                    using (var graphics = Graphics.FromImage(imgFront))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            graphics.DrawLine(transparentPen, graph.ShortestPath[i].NodePoint, graph.ShortestPath[i + 1].NodePoint);
                        }
                    }                    
                    pictureBoxGraph.Image = imgFront;
                    pictureBoxGraph.Refresh();
                    shortestFlag = true;
                    labelShortestPath.Visible = true;
                    labelShortestPath.Text += graph.MinWeight;
                }
                else
                {
                    CustomMsgBoxForm msgBoxWindow = new CustomMsgBoxForm();
                    DialogResult result = msgBoxWindow.Show("Graph must have at least 4 nodes!");
                    if (result == DialogResult.OK)
                    {
                        msgBoxWindow.Close();
                    }
                }
            }
        }        
    }
}
