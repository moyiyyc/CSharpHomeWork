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
            Deg1 = 30; Deg2 = 20; Per1 = 0.6; Per2 = 0.7; Leng= 100; N = 100;
            pen.Color= Color. Red;
            textBox1.DataBindings.Add("Text", this, "N",false, DataSourceUpdateMode.OnPropertyChanged);
            textBox7.DataBindings.Add("Text", this, "Leng", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox8.DataBindings.Add("Text", this, "Per2", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox9.DataBindings.Add("Text", this, "Per1", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox10.DataBindings.Add("Text", this, "Deg2", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox11.DataBindings.Add("Text", this, "Deg1", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        private Graphics graphics;
        public int N { get; set; }
        public double Leng { get; set; }
        public int Deg1 { get; set; }
        public int Deg2 { get; set; }
        public double Per1 { get; set; }
        public double Per2 { get; set; }
        public  Pen pen;
       




        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
         
            drawCayleyTree(n - 1, x1, y1, Per1 * leng, th + Deg1 * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, Per2 * leng, th - Deg2 * Math.PI / 180);


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
           
                //显示颜色对话框
                DialogResult dr = colorDialog1.ShowDialog();
                //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
                if (dr == DialogResult.OK)
                {
               
                pen.Color= colorDialog1.Color;
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics = this.panel1.CreateGraphics();
            graphics.Clear(panel1.BackColor);
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(this.N, panel1.Width / 2, panel1.Height - 20, this.Leng, -Math.PI / 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
