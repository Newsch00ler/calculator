using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorDereza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textNumerator1.Text = Properties.Settings.Default.numerator.ToString();
            textDenominator1.Text = Properties.Settings.Default.denominator.ToString();
            textNumerator2.Text = Properties.Settings.Default.numerator.ToString();
            textDenominator2.Text = Properties.Settings.Default.denominator.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction num1 = new Fraction();
            Fraction num2 = new Fraction();
            int sign = comboBox1.SelectedIndex;
            try
            {
                num1.numerator = int.Parse(this.textNumerator1.Text);
                num1.denominator = int.Parse(this.textDenominator1.Text);
                num2.numerator = int.Parse(this.textNumerator2.Text);
                num2.denominator = int.Parse(this.textDenominator2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textAns.Text = "";
                return;
            }
            if (Math.Abs(num1.numerator) >= Math.Abs(num1.denominator) || Math.Abs(num2.numerator) >= Math.Abs(num2.denominator))
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textAns.Text = "";
                return;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Неправильный знак", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Properties.Settings.Default.numerator = (int)num1.numerator;
                Properties.Settings.Default.denominator = (int)num1.denominator;
                Properties.Settings.Default.numerator = (int)num2.numerator;
                Properties.Settings.Default.denominator = (int)num2.denominator;
                Properties.Settings.Default.Save();
                if (sign == 0)
                {
                    var num3 = num1 + num2;
                    textAns.Text = $"{num3.numerator}";
                    textBox1.Text = $"{num3.denominator}";
                }
                else if (sign == 1)
                {
                    var num3 = num1 - num2;
                    textAns.Text = $"{num3.numerator}";
                    textBox1.Text = $"{num3.denominator}";
                }
                else if (sign == 2)
                {
                    var num3 = num1 * num2;
                    textAns.Text = $"{num3.numerator}";
                    textBox1.Text = $"{num3.denominator}";
                }
                else if (sign == 3)
                {
                    var num3 = num1 / num2;
                    textAns.Text = $"{num3.numerator}";
                    textBox1.Text = $"{num3.denominator}";
                }
            }
        }
    }
}
