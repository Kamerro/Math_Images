using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Images
{
    internal class Circle : AFigures
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
                        int solutionX = Math.Abs(i - locationX);
                        int solutionY = Math.Abs(j - locationY);
                        int solution = solutionX * solutionX + solutionY * solutionY;
                        
                        if (solution - armSquared > - arm && solution - armSquared < arm)  //TOOK ME WHOLE 2 HOURS!. DAAAAAAAAAAAAAMN! try to solve this in other way!
                        {
                            Color col = Color.Black;
                            btmp.SetPixel(i, j, col);
                        }
                    }
                }
            }
        }
    }
}
