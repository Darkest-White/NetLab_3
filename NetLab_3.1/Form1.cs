using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            int value = (int)numericUpDown1.Value;

            for (int i = 1; i <= value; i++)
            {
                textBox1.Text += i.ToString() + ' ';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            comboBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            textBox3.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal value1, value2;

            if (!decimal.TryParse(textBox4.Text, out value1))
            {
                Console.WriteLine("Error parse");
            }
            if (!decimal.TryParse(textBox5.Text, out value2))
            {
                Console.WriteLine("Error parse");
            }

            decimal result = value1 + value2;

            textBox6.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal value1, value2;

            if (!decimal.TryParse(textBox4.Text, out value1))
            {
                Console.WriteLine("Error parse");
            }
            if (!decimal.TryParse(textBox5.Text, out value2))
            {
                Console.WriteLine("Error parse");
            }

            decimal result = value1 - value2;

            textBox6.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal value1, value2;

            if (!decimal.TryParse(textBox4.Text, out value1))
            {
                Console.WriteLine("Error parse");
            }
            if (!decimal.TryParse(textBox5.Text, out value2))
            {
                Console.WriteLine("Error parse");
            }

            decimal result = value1 * value2;

            textBox6.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal value1, value2;

            if (!decimal.TryParse(textBox4.Text, out value1))
            {
                Console.WriteLine("Error parse");
            }
            if (!decimal.TryParse(textBox5.Text, out value2))
            {
                Console.WriteLine("Error parse");
            }

            decimal result = value1 / value2;

            textBox6.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            string[] lines = textBox7.Lines;

            foreach (string line in lines)
            {
                decimal value;
                if (decimal.TryParse(line, out value))
                {
                    comboBox2.Items.Add(value);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        } // WORK

        private void button9_Click(object sender, EventArgs e)
        {
            string[] lines = textBox9.Lines;
            List<string> nonNumericLines = new List<string>();

            foreach (string line in lines)
            {
                if (!double.TryParse(line, out _))
                {
                    nonNumericLines.Add(line);
                }
            }

            nonNumericLines.Reverse();
            textBox10.Lines = nonNumericLines.ToArray();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double a, b, h;

            if (!double.TryParse(textBox11.Text, out a) ||
                !double.TryParse(textBox12.Text, out b) ||
                !double.TryParse(textBox13.Text, out h))
            {
                textBox14.Text = "Invalid input. Please enter valid numeric values.";
                return;
            }

            textBox14.Clear();

            for (double x = a; x <= b; x += h)
            {
                double fx = Math.Sin(x) / (Math.Abs(x) + 1);
                textBox14.AppendText($"x={x:0.00};   f(x)={fx:0.00}\r\n");
            }
        }
    }
}