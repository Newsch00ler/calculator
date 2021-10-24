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
        }        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Fraction num1 = new Fraction();
            Fraction num2 = new Fraction();
            string sign = comboCheck.SelectedItem.ToString();
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
                return;
            }
            textAns.Text = num1.GetSum(num1, num2, sign);
        }
    }
}
