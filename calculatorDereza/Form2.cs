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
            int numerator1, denominator1, numerator2, denominator2;
            string sign;
            try
            {
                numerator1 = int.Parse(this.textNumerator1.Text);
                denominator1 = int.Parse(this.textDenominator1.Text);
                numerator2 = int.Parse(this.textNumerator2.Text);
                denominator2 = int.Parse(this.textDenominator2.Text);
                sign = comboCheck.SelectedItem.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textAns.Text = Logic2.Math(numerator1, denominator1, numerator2, denominator2, sign).ToString();
        }

        public class Logic2
        {
            public static string Math(int numerator1, int denominator1, int numerator2, int denominator2, string sign)
            {
                float sum = 0;
                float numerator = 0;
                float denominator = 0;
                string result = "";
                if (numerator1 < denominator1 && numerator2 < denominator2)
                {
                    if(sign == "+")
                    {
                        denominator = denominator1 * denominator2;
                        numerator = numerator1 * denominator2 + numerator2 * denominator1;
                        sum = numerator / denominator;
                    }
                    if (sign == "-")
                    {
                        denominator = denominator1 * denominator2;
                        numerator = numerator1 * denominator2 - numerator2 * denominator1;
                        sum = numerator / denominator;
                    }
                    if (sign == "*")
                    {
                        numerator = numerator1 *numerator2;
                        denominator = denominator1 * denominator2;
                        sum = numerator / denominator;
                    }
                    if (sign == "/")
                    {
                        numerator = numerator1 * denominator2;
                        denominator = denominator1 * numerator2;
                        sum = numerator / denominator;
                    }
                    result = String.Format("{0:f3}", sum);
                }
                else
                {
                    result = "Ошибка";
                }
                return result;
            }
        }
    }
}
