using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Images
{
    internal abstract class AFigures
    {
        protected PictureBox pb;
        protected Bitmap btmp;
        protected Point point;
        protected int setOff;
        protected int arm;
        protected int armSquared;
        protected int left;
        protected int right;
        protected int top;
        protected int bottom;
        protected int locationX;
        protected int locationY;

        public void setNewSetOff(int setOff)
        {
            this.setOff = setOff; 
        }
        public void SetNewProperties(Point pt)
        {
            savePosition(pt.X, pt.Y);
            arm = setOff / 2;
            armSquared = arm * arm;
            left = point.X - arm;
            right = point.X + arm;
            top = point.Y - arm;
            bottom = point.Y + arm;
            locationX = point.X;
            locationY = point.Y;

        }
        protected void savePosition(int x, int y)
        {
           this.point.X = x;
           this.point.Y = y;
        }

        public abstract void DrawFigure();

        public void setPictureBox(PictureBox pictureBox1)
        {
            this.pb = pictureBox1;
        }
        protected void setNewImage()
        {
            pb.Image = btmp as Image;
        }

        public PictureBox returnPictureBox()
        {
            return pb??null;
        }
    }
}
