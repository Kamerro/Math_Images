using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Images
{
    internal class SmoothCircle : AFigures
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
                        double distanceSquared = dx * dx + dy * dy;
                        if (distanceSquared < armSquared )
                        {

                            double normalizowany_dist = distanceSquared / (double)armSquared;
                            int wartosc = (int)(normalizowany_dist * 255);
                            Color col = Color.FromArgb(wartosc, wartosc, wartosc);
                            btmp.SetPixel(i, j, col);

                        }
                    }
                }
            }
        }
    }
}
