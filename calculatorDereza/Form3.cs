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
            /*textNumerator1.Text = Properties.Settings.Default.numerator.ToString();
            textDenominator1.Text = Properties.Settings.Default.denominator.ToString();*/
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
                textAnsNumerator.Text = "";
                textAnsDenominator.Text = "";
                return;
            }
            if (Math.Abs(num1.numerator) >= Math.Abs(num1.denominator))
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textAnsNumerator.Text = "";
                textAnsDenominator.Text = "";
                return;
            }
            else
            {
                /*Properties.Settings.Default.numerator = (int)num1.numerator;
                Properties.Settings.Default.denominator = (int)num1.denominator;
                Properties.Settings.Default.Save();*/
                textAnsNumerator.Text = num1.GetReduction(num1).numerator.ToString();
                textAnsDenominator.Text = num1.GetReduction(num1).denominator.ToString();
            }
        }
    }
}
