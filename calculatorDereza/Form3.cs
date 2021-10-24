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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction num1 = new Fraction();
            try
            {
                num1.numerator = int.Parse(this.textNumerator1.Text);
                num1.denominator = int.Parse(this.textDenominator1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (num1.numerator >= num1.denominator)
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textAnsNumerator.Text = num1.GetReduction(num1).numerator.ToString();
                textAnsDenominator.Text = num1.GetReduction(num1).denominator.ToString();
            }
        }
        
    }
}
