using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace MandelbrotDemo
{
    public partial class Form1 : Form
    {
        double hx=0, hy=0, x_, y_, n = 0;
        Bitmap bmp;

        Size size;
        double SizeArea, ScaleArea;

        public Form1()
        {
            InitializeComponent();
            
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            size = pictureBox1.Size;

            SizeArea = 3;
            ScaleArea = 3;
        }

        private void Draw()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            size = pictureBox1.Size;
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                x_ = (hx - SizeArea / 2) + x * (SizeArea / size.Width);
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    y_ = (hy - SizeArea / 2) + y * (SizeArea / size.Height);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z = z * z;
                        z += new Complex(x_, y_);
                        if (z.Magnitude > 2.0) break;
                    }
                    while (it < 100);
                    bmp.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
                pictureBox1.Image = bmp;
            }
        }

        private void btnUvel_Click(object sender, EventArgs e)
        {
            try
            {
                n = Math.Abs(Double.Parse(text.Text)); 
                SizeArea /= n;
                Draw();
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных, повторите еще раз");
            }                   
        }

        private void btnUmen_Click(object sender, EventArgs e)
        {
            try
            {
                n = Math.Abs(Double.Parse(text.Text));
                SizeArea *= n;
                Draw();
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных, повторите еще раз");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X,
                Y = e.Y;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    hx = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                    hy = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                    SizeArea /= ScaleArea;
                    Draw();
                    break;
                case MouseButtons.Middle:
                    SizeArea = 3;
                    ScaleArea = 3;
                    Draw();
                    break;
                case MouseButtons.Right:
                    x_ = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                    y_ = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                    SizeArea *= ScaleArea;
                    Draw();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw(); 
        }
    }
}
