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
            comboCheck.SelectedItem = Properties.Settings.Default.sign.ToString();
        }        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Fraction num1 = new Fraction();
            Fraction num2 = new Fraction();
            string sign = comboCheck.Text;
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
            if (num1.numerator >= num1.denominator || num2.numerator >= num2.denominator)
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textAns.Text = "";
                return;
            }
            else if (comboCheck.SelectedItem == null){
                MessageBox.Show("Неправильный знак", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Properties.Settings.Default.numerator = (int)num1.numerator;
                Properties.Settings.Default.denominator = (int)num1.denominator;
                Properties.Settings.Default.numerator = (int)num2.numerator;
                Properties.Settings.Default.denominator = (int)num2.denominator;
                Properties.Settings.Default.sign = sign;
                Properties.Settings.Default.Save();
                textAns.Text = num1.GetSum(num1, num2, sign);
            }
        }
    }
    /*public partial class Form2 : Form
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
                textAns.Text = "";
                return;
            }
            if (num1.numerator >= num1.denominator || num2.numerator >= num2.denominator)
            {
                MessageBox.Show("Неправильная дробь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textAns.Text = "";
                return;
            }
            else
            {
                textAns.Text = num1.GetSum(num1, num2, sign);
            }
        }
    }*/
}
