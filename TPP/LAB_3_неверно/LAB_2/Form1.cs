using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            radioButton1.Checked = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("1");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Button item in this.Controls.OfType<Button>())
            {
                item.BackColor = System.Drawing.Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("2");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("5");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 1 && !Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                this.textBox1.AppendText("");
            }
            else if (Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) && textBox1.Text.Length >= 1)
            {
                this.textBox1.AppendText("*");
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                this.textBox1.AppendText("*");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 1 && !Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                this.textBox1.AppendText("");
            }
            else if(Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) && textBox1.Text.Length >= 1)
            {
                this.textBox1.AppendText("/");
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                this.textBox1.AppendText("/");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 1 && !Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                this.textBox1.AppendText("");
            }
            else if (Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) && textBox1.Text.Length >= 1)
            {
                this.textBox1.AppendText("+");
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                this.textBox1.AppendText("+");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                this.textBox1.AppendText("-");
            }
            else if (textBox1.Text.Length == 1 && !Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                this.textBox1.AppendText("-");
            }
            else if (textBox1.Text.Length == 1)
            {
                this.textBox1.AppendText("-");
            }
            else if (textBox1.Text.Length == 2 && Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                this.textBox1.AppendText("-");
            }
            else if (Char.IsDigit(textBox1.Text[textBox1.Text.Length - 2]) && textBox1.Text.Length >= 2)
            {
                this.textBox1.AppendText("-");
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                this.textBox1.AppendText("-");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string first = "";
            string second = "";
            string res = "";
            char x= '0';
            bool flag = true;
            bool flag2 = true;
            res += textBox1.Text;
            foreach (char ch in textBox1.Text)
            {
                if ((Char.IsDigit(ch) || ch == '-' && flag2) && flag)
                {
                    first += ch;
                    flag2 = false;
                }
                else if (!Char.IsDigit(ch) && flag)
                {
                    x = ch;
                    flag = false;
                }
                else
                {
                    second += ch;
                }
            }
            if (x == '+')
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(first) + Convert.ToInt32(second));
            }
            else if (x == '-')
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(first) - Convert.ToInt32(second));
            }
            else if (x == '/')
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(first) / Convert.ToInt32(second));
            }
            else if (x == '*')
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(first) * Convert.ToInt32(second));
            }
            res += " = " + textBox1.Text + '\n';
            if (checkBox1.Checked) listBox1.Items.Add(res);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = true;
            button20.Visible = true;
            checkBox1.Visible = true;
            listBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = false;
            button20.Visible = false;
            checkBox1.Visible = false;
            listBox1.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
