using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    class FindCirclesCenters
    {
        Bitmap img, proImg;
        List<Point> pointList;
        Pen bluePen = new Pen(Color.LightBlue, 3);
        System.Drawing.SolidBrush blueBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue);
        System.Drawing.SolidBrush redBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        int x_i, y_i;   // Inicial X and Y values for getPixel
        int x_c, y_c;   // Center values for X and Y
        int x_f, y_f;   // Final X and Y values for getPixel
        int x_r;        // Circle radius
        int circleDiameter; // Circle diameter

        // Class constructor
        public FindCirclesCenters(Bitmap img, List<Point> pointList)
        {
            this.img = img;
            this.proImg = new Bitmap(img);
            this.pointList = pointList;
        }

        // Access modifier for proImg
        public Bitmap ProImage
        {
            get { return proImg; }
        }

        // Draws and fills circles
        public void DrawCircle(Bitmap img, Point p1, int d)
        {
            using (var graphics = Graphics.FromImage(proImg))
            {
                graphics.DrawEllipse(bluePen, p1.X, p1.Y, d, d);
                graphics.FillEllipse(blueBrush, p1.X, p1.Y, d, d);
            }
        }

        // Draws center
        public void DrawCenter(Bitmap img, Point p1)
        {            
            using (var graphics = Graphics.FromImage(proImg))
            {
                graphics.FillEllipse(redBrush, p1.X - 3, p1.Y - 3, 8, 8);
            }
        }

        // FindCircle
        public void FindCircle()
        {
            for (int j = 0; j < proImg.Height; j++)
                for (int i = 0; i < proImg.Width; i++)
                    if (proImg.GetPixel(i, j).R == 0)
                        if (proImg.GetPixel(i, j).G == 0)
                            if (proImg.GetPixel(i, j).B == 0)
                                FindCircleCenter(i, j);
        }

        // Finds the circle center
        public void FindCircleCenter(int i, int j)
        {            
            x_i = i;
            y_i = j;

            // Finds the X value for the center
            for (x_f = x_i; x_f < proImg.Width; x_f++)
            {
                if (proImg.GetPixel(x_f, y_i).R == 255 || proImg.GetPixel(x_f, y_i).G == 255 || proImg.GetPixel(x_f, y_i).B == 255)
                {
                    x_f--;
                    break;
                }

            }
            x_c = (x_i + x_f) / 2;

            // Finds the Y value for the center
            for (y_f = y_i; y_f < proImg.Height; y_f++)
            {
                if (proImg.GetPixel(x_c, y_f).R == 255 || proImg.GetPixel(x_c, y_f).G == 255 || proImg.GetPixel(x_c, y_f).B == 255)
                {
                    y_f--;
                    break;
                }

            }
            y_c = (y_i + y_f) / 2;

            // Finds the x value for the square used to draw the circle
            for (x_r = x_c; x_r < proImg.Width; x_r--)
            {
                if (proImg.GetPixel(x_r, y_c).R == 255)
                    if (proImg.GetPixel(x_r, y_c).G == 255)
                        if (proImg.GetPixel(x_r, y_c).B == 255)
                        {
                            x_r++;
                            break;
                        }

            }

            // Adds centerPoint to list
            Point p1 = new Point(x_r, y_i);
            circleDiameter = y_f - y_i;
            DrawCircle(proImg, p1, circleDiameter + 1);
            Point centerPoint = new Point(x_c, y_c);
            pointList.Add(centerPoint);
            DrawCenter(proImg, centerPoint);

        }

    }
}
