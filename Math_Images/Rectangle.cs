using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Images
{
    internal class Rectangle : AFigures
    {
        public Rectangle()
        {
            
        }
        public override void DrawFigure()
        {
            btmp = pb.Image as Bitmap;
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if ((i == left || i == right || j == top || j == bottom) && (i >= 0 && i < btmp.Width && j >= 0 && j < btmp.Height))
                    {
                        Color col = Color.Black;
                        btmp.SetPixel(i, j, col);
                    }
                }
            }
        }
    }
}
