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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            /*textNum1.Text = Properties.Settings.Default.numerator.ToString();
            textDen1.Text = Properties.Settings.Default.denominator.ToString();
            textNum2.Text = Properties.Settings.Default.numerator.ToString();
            textDen2.Text = Properties.Settings.Default.denominator.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction num1 = new Fraction();
            Fraction num2 = new Fraction();
            try
            {
                num1.numerator = int.Parse(this.textNum1.Text);
                num1.denominator = int.Parse(this.textDen1.Text);
                num2.numerator = int.Parse(this.textNum2.Text);
                num2.denominator = int.Parse(this.textDen2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSign.Text = "";
                return;
            }
            if (Math.Abs(num1.numerator) >= Math.Abs(num1.denominator) || Math.Abs(num2.numerator) >= Math.Abs(num2.denominator))
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSign.Text = "";
                return;
            }
            else
            {
                /*Properties.Settings.Default.numerator = (int)num1.numerator;
                Properties.Settings.Default.denominator = (int)num1.denominator;
                Properties.Settings.Default.numerator = (int)num2.numerator;
                Properties.Settings.Default.denominator = (int)num2.denominator;
                Properties.Settings.Default.Save();*/
                textSign.Text = num1.GetCompare(num1, num2);
            }
        }
    }
}
