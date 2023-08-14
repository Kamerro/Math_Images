using System;
using System.Drawing;
using System.Windows.Forms;

namespace Math_Images
{
    internal class Generator
    {
        internal static void GenerateSinOnPictureBox(PictureBox pictureBox1)
        {
            Bitmap btmp = pictureBox1.Image as Bitmap;
          for(int i =0; i< pictureBox1.Width; i++)
          {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                        //10 hz. 
                        int value = (int)(Math.Abs(Math.Sin((double)(i * j) * (2 * Math.PI * 10) / (double)(pictureBox1.Width * pictureBox1.Height))) * 255);
                        btmp.SetPixel(i, j, Color.FromArgb(value, value, value));
                    
                       // MessageBox.Show(value.ToString());
                }
          }
          pictureBox1.Image = btmp;
        }
        internal static void GenerateCosOnPictureBox(PictureBox pictureBox1)
        {
            Bitmap btmp = pictureBox1.Image as Bitmap;
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    //10 hz. 
                    int value = (int)(Math.Abs(Math.Cos((double)(i * j) * (2 * Math.PI * 10) / (double)(pictureBox1.Width * pictureBox1.Height))) * 255);
                    btmp.SetPixel(i, j, Color.FromArgb(value, value, value));

                    // MessageBox.Show(value.ToString());
                }
            }
            pictureBox1.Image = btmp;
        }
        internal static void GenerateSinCosOnPictureBox(PictureBox pictureBox1)
        {
            Bitmap btmp = pictureBox1.Image as Bitmap;
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    //10 hz. 
                    int value = (int)(Math.Abs(Math.Cos((double)(i * j) * (2 * Math.PI * 10) / (double)(pictureBox1.Width * pictureBox1.Height))) * 127) +
                        (int)(Math.Abs(Math.Sin((double)(i * j) * (2 * Math.PI * 10) / (double)(pictureBox1.Width * pictureBox1.Height))) * 128);
                    btmp.SetPixel(i, j, Color.FromArgb(value, value, value));

                    // MessageBox.Show(value.ToString());
                }
            }
            pictureBox1.Image = btmp;
        }
    }
}