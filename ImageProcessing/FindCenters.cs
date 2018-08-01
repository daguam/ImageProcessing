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
    public partial class FindCenters : Form
    {
        Boolean drag;
        int mouseX;
        int mouseY;
        public FindCenters()
        {
            InitializeComponent();
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
    }
}
