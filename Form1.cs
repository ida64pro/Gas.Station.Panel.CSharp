using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            if (index == 0)
            {
                textBox1.Text = "6,4";
            }
            else if (index == 1)
            {
                textBox1.Text = "5,5";
            }
            else if (index == 2)
            {
                textBox1.Text = "7,4";
            }
            else if (index == 3)
            {
                textBox1.Text = "9,3";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void litr_TextChanged(object sender, EventArgs e)
        {
            if (litr.Text == "")
            {
                litr.Text = "1";
            }
            double x = double.Parse(litr.Text) * double.Parse(textBox1.Text);
            textBox2.Text = x.ToString();
        }

        private void liter_EnabledChanged(object sender, EventArgs e)
        {
        }
        private void liter_CheckedChanged(object sender, EventArgs e)
        {
            rub.Enabled = false;
            litr.Enabled = true;
        }

        private void sum_CheckedChanged(object sender, EventArgs e)
        {
            rub.Enabled = true;
            litr.Enabled = false;
        }

        private void rub_TextChanged(object sender, EventArgs e)
        {
            if (litr.Text == "")
            {
                rub.Text = "1";
            }
            if (Convert.ToDouble(litr.Text) < 10)
            {
                rub.Text = "10";
            }
            double x = double.Parse(rub.Text) * double.Parse(textBox1.Text);
            textBox2.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (double.Parse(textBox2.Text) + double.Parse(textBox11.Text)).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox1.Checked == false)
            {
                textBox7.Enabled = false;
                cost = cost - (double.Parse(textBox7.Text) * double.Parse(HotDog.Text));
                textBox11.Text = cost.ToString();

            }
            else
            {
                textBox7.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox2.Checked == false)
            {
                textBox8.Enabled = false;
                cost = cost - (double.Parse(textBox8.Text) * double.Parse(Pepsi.Text));
                textBox11.Text = cost.ToString();
            }
            else
            {
                textBox8.Enabled = true;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox2.Checked == false)
            {
                textBox9.Enabled = false;
                cost = cost - (double.Parse(textBox9.Text) * double.Parse(Choco.Text));
                textBox11.Text = cost.ToString();
            }
            else
            {
                textBox9.Enabled = true;
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox4.Checked == false)
            {
                textBox10.Enabled = false;
                cost = cost - (double.Parse(textBox10.Text) * double.Parse(Lepeshka.Text));
                textBox11.Text = cost.ToString();
            }
            else
            {
                textBox10.Enabled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox1.Checked)
            {
                cost = (double.Parse(textBox7.Text) * double.Parse(HotDog.Text)) + cost;
                textBox11.Text = cost.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox2.Checked)
            {
                cost = (double.Parse(textBox8.Text) * double.Parse(Pepsi.Text)) + cost;
                textBox11.Text = cost.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox3.Checked)
            {
                cost = (double.Parse(textBox9.Text) * double.Parse(Choco.Text)) + cost;
                textBox11.Text = cost.ToString();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox11.Text);
            if (checkBox4.Checked)
            {
                cost = (double.Parse(textBox10.Text) * double.Parse(Lepeshka.Text)) + cost;
                textBox11.Text = cost.ToString();
            }
        }
    }
}
