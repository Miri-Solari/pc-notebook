using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("1");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Button item in grid1.Children.OfType<Button>())
            {
                item.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255))));
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
            else if (Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) && textBox1.Text.Length >= 1)
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
            char x = '0';
            bool flag = true;
            bool flag2 = true;
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
        }

    }

}
