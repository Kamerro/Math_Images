using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Point p = e.Location;
            PictureBox thisSender = (sender as PictureBox);
            WyzerujKolor(thisSender);
            Bitmap thisBitmap = thisSender.Image as Bitmap;
            #region params
            int setOff = 100;
            int arm = setOff / 2;
            int armSquared = arm * arm;
            int left = p.X - arm;
            int right = p.X + arm;
            int top = p.Y - arm;
            int bottom = p.Y + arm;
            #endregion
            for (int i = left; i <= right; i++)
            {
                for(int j = top; j <= bottom; j++)
                {
                    int dx = i - e.Location.X;
                    int dy = j - e.Location.Y;
                    double distanceSquared = dx*dx + dy*dy;
                    if ( distanceSquared <= armSquared)
                    {
                        if (i > 0 && i < thisBitmap.Width && j > 0 && j < thisBitmap.Height)
                        {
                                double normalizowany_dist = distanceSquared/ (double)armSquared;
                                int wartosc = (int)(normalizowany_dist * 255);
                                Color col = Color.FromArgb(wartosc, wartosc, wartosc);
                                thisBitmap.SetPixel(i, j, col);
                        }
                        }
                    }
            }
            thisSender.Image = thisBitmap;
            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());
        }

        private void WyzerujKolor(PictureBox sender)
        {
            var thisBitmap = sender.Image as Bitmap;
            for (int i = 0; i < sender.Width; i++)
            {
                for (int j = 0; j < sender.Height; j++)
                {
                    thisBitmap.SetPixel(i, j, Color.White);
                }
            }
            sender.Image = thisBitmap;
        }
    }
}
