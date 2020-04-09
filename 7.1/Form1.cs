using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
         private Graphics graphics;
        int n;
        double leng;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this. n = int.Parse(Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            leng=int.Parse(Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             per1 = double.Parse(Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             per2 = double.Parse(Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             th1 = double.Parse(Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             th2 = double.Parse(Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "black":
                    pen.Color = Color.Black;
                    break;
                case "red":
                    pen.Color = Color.Red;
                    break;


                default:
                    pen.Color = Color.Black;
                    break;
            }
            
        }
        

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen,
                (int)x0, (int)y0, (int)x1, (int)y1) ;
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, 100, -Math.PI / 2);
        }

       
    }
   
}
