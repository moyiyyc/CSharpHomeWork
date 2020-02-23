using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "÷" });
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(this.textBox1.Text.Trim());
            int num2 = Convert.ToInt32(this.textBox2.Text.Trim());
            switch (comboBox1.Text)
            {
                case "+":
                    label1.Text = $"{ num1 + num2}";
                    break;
                case "-":
                    label1.Text = $"{ num1 - num2}";
                    break;
                case "*":
                    label1.Text = $"{ num1 * num2}";
                    break;
                case "÷":
                    if (num2 != 0)
                    {
                        label1.Text = $"{ num1 / num2}";
                    }
                    else
                    {
                        label1.Text = "0 can't be divided";
                    }
                    break;
            }

        }
    }
}
