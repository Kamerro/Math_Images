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
            ClearPb(pictureBox1);
            lbl_size.Text = $"size of pen:{trackBar1.Value}";
        }
        internal AFigures afigure;

        private void btn_smooth_Click(object sender, EventArgs e)
        {
            afigure = new SmoothCircle();
            afigure.setPictureBox(pictureBox1);
        }
        private void btn_cross_Click(object sender, EventArgs e)
        {
            afigure = new Cross();
            afigure.setPictureBox(pictureBox1);
        }
        private void btn_circle_Click(object sender, EventArgs e)
        {
            afigure = new Circle();
            afigure.setPictureBox(pictureBox1);
        }
        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            afigure = new Rectangle();
            afigure.setPictureBox(pictureBox1);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_size.Text = $"size of pen:{trackBar1.Value}";
            afigure.setNewSetOff(trackBar1.Value);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (afigure != null)
            {
                afigure.setNewSetOff(trackBar1.Value);
                ClearPb(afigure.returnPictureBox());
                Point pt = new Point(e.Location.X, e.Location.Y);
                afigure.SetNewProperties(pt);
                afigure.DrawFigure();
            }
        }
        private void ClearPb(PictureBox sender)
        {
                Bitmap btmp = sender.Image as Bitmap;
                for (int i = 0; i < sender.Width; i++)
                {
                    for (int j = 0; j < sender.Height; j++)
                    {
                    btmp.SetPixel(i, j, Color.Wheat);
                    }
                }
                sender.Image = btmp;
            }

        private void btnFilledRectangle_Click(object sender, EventArgs e)
        {
            afigure = new FilledRectangle();
            afigure.setPictureBox(pictureBox1);
        }

        private void btn_SinWaves_Click(object sender, EventArgs e)
        {
            Generator.GenerateSinOnPictureBox(pictureBox1);
        }

        private void btn_CosWaves_Click(object sender, EventArgs e)
        {
            Generator.GenerateCosOnPictureBox(pictureBox1);
        }

        private void btn_Cos_Sin_Waves_Click(object sender, EventArgs e)
        {
            Generator.GenerateSinCosOnPictureBox(pictureBox1);
        }
    }
    
}
