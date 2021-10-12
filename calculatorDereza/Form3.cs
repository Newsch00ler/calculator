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
            int numerator1, denominator1;
            try
            {
                numerator1 = int.Parse(this.textNumerator1.Text);
                denominator1 = int.Parse(this.textDenominator1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textAnsNumerator.Text = Logic3.MathNum(numerator1, denominator1).ToString();
            textAnsDenominator.Text = Logic3.MathDen(numerator1, denominator1).ToString();
        }
        public class Logic3
        {
            public static string MathNum(int numerator1, int denominator1)
            {
                int maxdel;
                int numerator2 = numerator1;
                int numerator;
                int denominator2 = denominator1;
                string result1;
                if (numerator1 < denominator1 && numerator2 < denominator2)
                {
                    while (denominator1 != 0)
                    {
                        var t = denominator1;
                        denominator1 = numerator1 % denominator1;
                        numerator1 = t;
                    }
                    maxdel = numerator1;
                    numerator = numerator2 / maxdel;
                    result1 = numerator.ToString();
                }
                else
                {
                    result1 = "Ошибка";
                }
                return result1;
            }
            public static string MathDen(int numerator1, int denominator1)
            {
                int maxdel;
                int denominator2 = denominator1;
                int denominator;
                int numerator2 = numerator1;
                string result2;
                if (numerator1 < denominator1 && numerator2 < denominator2)
                {
                    while (denominator1 != 0)
                    {
                        var t = denominator1;
                        denominator1 = numerator1 % denominator1;
                        numerator1 = t;
                    }
                    maxdel = numerator1;
                    denominator = denominator2 / maxdel;
                    result2 = denominator.ToString();
                }
                else
                {
                    result2 = "Ошибка";
                }
                return result2;
            }
        }
    }
}
