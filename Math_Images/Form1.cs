using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = (Image)new Bitmap(pictureBox1.Width, pictureBox1.Height);
            WyzerujKolor(pictureBox1);
            lbl_size.Text = $"size of pen:{trackBar1.Value}";
        }
        public int setOff = 5;

        
        private void WyzerujKolor(PictureBox sender)
        {
            var thisBitmap = sender.Image as Bitmap;
            for (int i = 0; i < sender.Width; i++)
            {
                for (int j = 0; j < sender.Height; j++)
                {
                    thisBitmap.SetPixel(i, j, Color.Wheat);
                }
            }
            sender.Image = thisBitmap;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_smooth_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseMove -= methodCross;
            pictureBox1.MouseMove -= methodCircle;
            pictureBox1.MouseMove -= methodRectangle;
            pictureBox1.MouseMove += methodSmooth;
        }
        private void btn_cross_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseMove -= methodSmooth;
            pictureBox1.MouseMove -= methodCircle;
            pictureBox1.MouseMove -= methodRectangle;
            pictureBox1.MouseMove += methodCross;
        }
        private void btn_circle_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseMove -= methodSmooth;
            pictureBox1.MouseMove -= methodRectangle;
            pictureBox1.MouseMove -= methodCross;
            pictureBox1.MouseMove += methodCircle;
        }
        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseMove -= methodSmooth;
            pictureBox1.MouseMove -= methodCross;
            pictureBox1.MouseMove -= methodCircle;
            pictureBox1.MouseMove += methodRectangle;
        }

        private void methodRectangle(object sender, MouseEventArgs e)
        {

            Point p = e.Location;
            PictureBox thisSender = (sender as PictureBox);
            WyzerujKolor(thisSender);
            Bitmap thisBitmap = thisSender.Image as Bitmap;
            #region params
            int arm = setOff / 2;
            int armSquared = arm * arm;
            int left = p.X - arm;
            int right = p.X + arm;
            int top = p.Y - arm;
            int bottom = p.Y + arm;
            int locationX = e.Location.X;
            int locationY = e.Location.Y;
            #endregion
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if ((i ==left || i== right || j==top || j == bottom)&&(i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height))
                    { 

                                Color col = Color.Black;
                        thisBitmap.SetPixel(i, j, col);
                    }
                }
            }
            thisSender.Image = thisBitmap;
        }

        private void methodCross(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            PictureBox thisSender = (sender as PictureBox);
            WyzerujKolor(thisSender);
            Bitmap thisBitmap = thisSender.Image as Bitmap;
            #region params
            int arm = setOff / 2;
            int armSquared = arm * arm;
            int left = p.X - arm;
            int right = p.X + arm;
            int top = p.Y - arm;
            int bottom = p.Y + arm;
            int locationX = e.Location.X;
            int locationY = e.Location.Y;
            #endregion
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                    {
                        int dx = i - locationX;
                        int dy = j - locationY;
                        double distanceSquared = Math.Pow(Math.Cos(dx),2) + Math.Pow(Math.Sin(dy),2);
                        if (Math.Sqrt(distanceSquared) == 1)
                        {
                            if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                            {
    
                                thisBitmap.SetPixel(i, j, Color.Black);
                            }
                        }
                    }
                }
            }
            thisSender.Image = thisBitmap;
        }

        private void methodSmooth(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            PictureBox thisSender = (sender as PictureBox);
            WyzerujKolor(thisSender);
            Bitmap thisBitmap = thisSender.Image as Bitmap;
            #region params
            int arm = setOff / 2;
            int armSquared = arm * arm;
            int left = p.X - arm;
            int right = p.X + arm;
            int top = p.Y - arm;
            int bottom = p.Y + arm;
            int locationX = e.Location.X;
            int locationY = e.Location.Y;
            #endregion
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                    {
                        int dx = i - locationX;
                        int dy = j - locationY;
                        double distanceSquared = dx * dx + dy * dy;
                        if (distanceSquared <= armSquared)
                        {
                            if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                            {
                                double normalizowany_dist = distanceSquared / (double)armSquared;
                                int wartosc = (int)(normalizowany_dist * 255);
                                Color col = Color.FromArgb(wartosc, wartosc, wartosc);
                                thisBitmap.SetPixel(i, j, col);
                            }
                        }
                    }
                }
            }
            thisSender.Image = thisBitmap;
        }

        private void methodCircle(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            PictureBox thisSender = (sender as PictureBox);
            WyzerujKolor(thisSender);
            Bitmap thisBitmap = thisSender.Image as Bitmap;
            #region params
            int arm = setOff / 2;
            int armSquared = arm * arm;
            int left = p.X - arm;
            int right = p.X + arm;
            int top = p.Y - arm;
            int bottom = p.Y + arm;
            int locationX = e.Location.X;
            int locationY = e.Location.Y;
            #endregion
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                    {
                        int dx = i - locationX;
                        int dy = j - locationY;
                        double distance = Math.Sqrt(dx * dx + dy * dy);
                        if (distance-arm > -0.5 && distance-arm < 0.5)
                        {
                            if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                            {

                                thisBitmap.SetPixel(i, j, Color.Black);
                            }
                        }
                    }
                }
            }
            thisSender.Image = thisBitmap;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_size.Text = $"size of pen:{trackBar1.Value}";
            setOff = trackBar1.Value;
        }
    }
}
