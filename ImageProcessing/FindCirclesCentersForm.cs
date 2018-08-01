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
    public partial class FindCirclesCentersForm : Form
    {
        Boolean drag;
        Boolean fail;   // Flag used to prevent opening the form when failing to process image
        int mouseX;
        int mouseY;
        Bitmap img;
        List<Point> pointList;

        public FindCirclesCentersForm(Bitmap img, List<Point> pointList)
        {
            this.img = new Bitmap(img);
            this.pointList = pointList;
            this.fail = fail;
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
            this.pictureBoxFindCC.Image = findCC.ProImage;  // Gets image from findCC and sets it to the pictureBox
            listBoxCenters.Items.Clear();

            // Adds points to the listBox
            foreach (Point p in pointList)
            {
                listBoxCenters.Items.Add(p);
            }
            pointList.Clear();
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

        // Access modifier for fail
        public Boolean Fail
        {
            get { return fail; }
        }
    }
}
