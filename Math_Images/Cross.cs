using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Images
{
    internal class Cross : AFigures
    {
        public override void DrawFigure()
        {
            btmp = pb.Image as Bitmap;
            for (int i = left; i <= right; i++)
            {
                for (int j = top; j <= bottom; j++)
                {
                    if (i >= 0 && i < btmp.Width && j >= 0 && j < btmp.Height)
                    {
                        int dx = i - locationX;
                        int dy = j - locationY;
                        double distanceSquared = Math.Pow(Math.Cos(dx), 2) + Math.Pow(Math.Sin(dy), 2);
                        if (Math.Sqrt(distanceSquared) == 1)
                        {
                            btmp.SetPixel(i, j, Color.Black);

                        }
                    }
                }
            }
        }
    }
}
