using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_algorithm_test
{
    public partial class Form1 : Form
    {
        dotNetRandom dNRnd = new dotNetRandom();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void drawImage_dNRnd()
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
                        r = 0; g = 0; b = 0;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                    else
                    {
                        r = 255; g = 255; b = 255;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
            }
            pictureBox1.Image = bmp;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            switch (cb_algo.SelectedIndex)
            {
                case 0:
                    drawImage_dNRnd();
                    break;

                case 1:
                    break;

                default:
                    break;
            }
        }
    }
 }

