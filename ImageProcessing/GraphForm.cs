using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class GraphForm : Form
    {
        Graph graph;
        Boolean drag;
        Boolean fail;   // Flag used to prevent opening the form when failing to process image
        int mouseX;
        int mouseY;
        Bitmap imgGraph;
        List<Point> pointList;
        Font drawFont = new Font("Ebrima", 16, FontStyle.Bold);
        Pen redPen = new Pen(Color.Red, 6);

        public GraphForm(Bitmap img)
        {
            this.graph = new Graph();
            this.imgGraph = new Bitmap(img);
            this.pointList = new List<Point>();
            InitializeComponent();
            FindCirclesCenters findCC = new FindCirclesCenters(img, pointList);
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
            graph.InitializeGraph(pointList);
            graph.CompleteGraph();
            using (var graphics = Graphics.FromImage(imgGraph))
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
                    int recenter = 15;
                    Point centerPoint = new Point(n.NodePoint.X - recenter, n.NodePoint.Y - recenter);
                    graphics.DrawString(n.NodeNum.ToString(), drawFont, Brushes.White, centerPoint);
                }
            }
            pictureBoxGraph.Image = imgGraph;
        }

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
            graph.BruteForceShortest();
            if (graph.ShortestPath.Count > 3)
            {
                using (var graphics = Graphics.FromImage(imgGraph))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        graphics.DrawLine(redPen, graph.ShortestPath[i].NodePoint, graph.ShortestPath[i+1].NodePoint);
                    }
                }
                pictureBoxGraph.Image = imgGraph;
            }
        }

        // Access modifier for fail
        public Boolean Fail
        {
            get { return fail; }
        }
    }
}
