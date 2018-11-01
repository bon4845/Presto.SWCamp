using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        double prevValue = 0;

        private void Add(int value)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += value.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            prevValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double current = double.Parse(textBox1.Text);
            if (label1.Text == "+")
            {
                textBox1.Text = (prevValue + current).ToString();
            }
            else if (label1.Text == "-")
            {
                textBox1.Text = (prevValue - current).ToString();
            }
            else if (label1.Text == "*")
            {
                textBox1.Text = (prevValue * current).ToString();

            }
            else if (label1.Text == "/")
            {
                textBox1.Text = (prevValue / current).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            prevValue = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            prevValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "*";
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            prevValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}