using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class MenuForm : Form
    {
        Boolean drag;
        int mouseX;
        int mouseY;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        string path = null;
        string correct = string.Empty;

        public MenuForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);    // Allows window resize (Double Buffered is set to true)
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Creates 1 point resize for window
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);     // Draws borders
        }

        // Resize
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        // Fullscreen/Normal window mode
        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                buttonFullScreen.Text = "2";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                buttonFullScreen.Text = "1";
            }
        }

        // Minimize window
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Load Image to pictureBox
        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            this.openFileDialogImg.ShowDialog();
            path = openFileDialogImg.FileName;
            try
            {
                pictureBoxImg.Load(path);
                correct = path;
            }
            catch (FileNotFoundException)
            {
                CustomMsgBoxForm msgBoxWindow = new CustomMsgBoxForm();
                DialogResult result = msgBoxWindow.Show("Image was not selected!");
                if (result == DialogResult.OK)
                {
                    msgBoxWindow.Close();

                }
            }
            catch (InvalidOperationException)
            {
                if (correct != string.Empty)
                {
                    pictureBoxImg.Load(correct);
                }
                else
                {
                    CustomMsgBoxForm msgBoxWindow = new CustomMsgBoxForm();
                    DialogResult result = msgBoxWindow.Show("Image was not selected!");
                    if (result == DialogResult.OK)
                    {
                        msgBoxWindow.Close();
                    }
                }
            }
            catch (ArgumentException)
            {
                if (correct != string.Empty)
                {
                        pictureBoxImg.Load(correct);
                }
                CustomMsgBoxForm msgBoxWindow = new CustomMsgBoxForm();
                DialogResult result = msgBoxWindow.Show("File Format is not valid!");
                if (result == DialogResult.OK)
                {
                    openFileDialogImg.Reset();  // Resets openDialog.FileName
                    msgBoxWindow.Close();
                }
            }
            
        }
    }
}
