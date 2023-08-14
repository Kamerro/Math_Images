using System.Drawing;

namespace Math_Images
{
    internal class FilledRectangle : AFigures
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
                        Color col = Color.Black;
                        btmp.SetPixel(i, j, col);
                    }
                }
            }
        }
    }
}