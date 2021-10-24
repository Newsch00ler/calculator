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
            if (num1.numerator >= num1.denominator || num2.numerator >= num2.denominator)
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSign.Text = "";
                return;
            }
            else
            {
                textSign.Text = num1.GetCompare(num1, num2);
            }
        }
    }
}
