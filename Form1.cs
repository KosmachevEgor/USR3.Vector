using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сложение
{
    public partial class Form1 : Form
    {
        float x0, y0;
        double Ax, Ay, Bx, By, Cx, Cy, A, B, C;
        int I;

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            In();
            CALC2();
            Out();
            I = Convert.ToInt32(textBox10.Text);
            float ax, ay, bx, by, cx, cy;
            ay = (y0 - I * (float)Ay);
            ax = (x0 + I * (float)Ax);
            bx = (x0 + I * (float)Bx);
            by = (y0 - I * (float)By);
            cx = (x0 + I * (float)Cx);
            cy = (y0 - I * (float)Cy);
            Graphics z = pictureBox1.CreateGraphics();
            Pen p2 = new Pen(System.Drawing.Color.Green);
            Pen p3 = new Pen(System.Drawing.Color.Blue);
            Pen p4 = new Pen(System.Drawing.Color.Red);
            z.DrawLine(p2, x0, y0, ax, ay);
            z.DrawLine(p3, x0, y0, bx, by);
            z.DrawLine(p4, bx, by, ax, ay);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            In();
            CALC();
            Out();
            I = Convert.ToInt32(textBox10.Text);
            float ax, ay, bx, by, cx, cy;
            ay = (y0 - I * (float)Ay);
            ax = (x0 + I * (float)Ax);
            bx = (x0 + I * (float)Bx);
            by = (y0 - I * (float)By);
            cx = (x0 + I * (float)Cx);
            cy = (y0 - I * (float)Cy);
            Graphics z = pictureBox1.CreateGraphics();
            Pen p2 = new Pen(System.Drawing.Color.Green);
            Pen p3 = new Pen(System.Drawing.Color.Blue);
            Pen p4 = new Pen(System.Drawing.Color.Red);
            z.DrawLine(p2, x0, y0, ax, ay);
            z.DrawLine(p3, x0, y0, bx, by);
            z.DrawLine(p4, x0, y0, cx, cy);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            I = Convert.ToInt32(textBox10.Text);
            Graphics g = pictureBox1.CreateGraphics();
            Pen p1 = new Pen(System.Drawing.Color.Black);
            p1.Width = 2;
            x0 = pictureBox1.Width / 2;
            y0 = pictureBox1.Height / 2;
            g.DrawLine(p1, x0, y0, 500, y0);
            g.DrawLine(p1, x0, y0, 0, y0);
            g.DrawLine(p1, x0, y0, x0, 0);
            g.DrawLine(p1, x0, y0, x0, 500);
            SETKA();
        }
        private void In()
        {
            Ax = Convert.ToDouble(textBox1.Text);
            Ay = Convert.ToDouble(textBox2.Text);
            Bx = Convert.ToDouble(textBox4.Text);
            By = Convert.ToDouble(textBox5.Text);
        }
        private void CALC()
        {
            A = Math.Sqrt(Ax * Ax + Ay * Ay);
            B = Math.Sqrt(Bx * Bx + By * By);
            Cx = Ax + Bx;
            Cy = Ay + By;
            C = Math.Sqrt(Cx * Cx + Cy * Cy);
        }
        private void CALC2()
        {
            A = Math.Sqrt(Ax * Ax + Ay * Ay);
            B = Math.Sqrt(Bx * Bx + By * By);
            Cx = Ax - Bx;
            Cy = Ay - By;
            C = Math.Sqrt(Cx * Cx + Cy * Cy);
        }
        private void Out()
        {
            textBox3.Text = Convert.ToString(A);
            textBox6.Text = Convert.ToString(B);
            textBox9.Text = Convert.ToString(C);
            textBox7.Text = Convert.ToString(Cx);
            textBox8.Text = Convert.ToString(Cy);
        }
        public void SETKA() // отрисовка сетки
        {
            int x, y;
            x = Convert.ToInt32(x0);
            y = Convert.ToInt32(y0);
            for (int i = y; i < 500; i = i + I) // отрисока сетки оу по правую сторону
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(Brushes.Gray, 1), new Point(i, 0), new Point(i, 700));
            }
            for (int i = y; i > 0; i = i - I) // отрисока сетки оу по левую сторону
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(Brushes.Gray, 1), new Point(i, 0), new Point(i, 700));
            }
            for (int i = x; i < 500; i = i + I) // отрисока сетки ох по правую сторону
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(Brushes.Gray, 1), new Point(0, i), new Point(900, i));
            }
            for (int i = x; i > 0; i = i - I) // отрисока сетки ох по левую сторону
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(Brushes.Gray, 1), new Point(0, i), new Point(900, i));
            }
        }
    }
}
