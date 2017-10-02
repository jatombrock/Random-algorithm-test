using System;
using System.Drawing;


namespace Random_algorithm_test
{
    public class dotNetRandom
    {
       // Form1 f1 = new Form1();
        public void drawImage()
        {
            int width = 500, height = 500;
            Bitmap bmp = new Bitmap(width, height);
            Random rand = new Random();
            int a = 255;
            int color;
            int r; int g; int b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    color = rand.Next(0, 2);

                    if (color == 0)
                    {
                        r = 0;  g = 0;  b = 0;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                    else
                    {
                        r = 255;  g = 255;  b = 255;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
            }

            //f1.pictureBox1.Image = bmp;

        }
    }
}
