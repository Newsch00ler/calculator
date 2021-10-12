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
            int numerator1, denominator1, numerator2, denominator2;
            try
            {
                numerator1 = int.Parse(this.textNum1.Text);
                denominator1 = int.Parse(this.textDen1.Text);
                numerator2 = int.Parse(this.textNum2.Text);
                denominator2 = int.Parse(this.textDen2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textSign.Text = Logic4.Compare(numerator1, denominator1, numerator2, denominator2).ToString();
        }

        public class Logic4
        {
            public static string Compare(int numerator1, int denominator1, int numerator2, int denominator2)
            {
                string result = "";
                if (numerator1 * denominator2 < numerator2 * denominator1)
                {
                    result = "<";
                }
                if (numerator1 * denominator2 > numerator2 * denominator1)
                {
                    result = ">";
                }
                if (numerator1 * denominator2 == numerator2 * denominator1)
                {
                    result = "=";
                }
                if (numerator1 >= denominator1 || numerator2 >= denominator2)
                {
                    result = "Ошибка";
                }
                return result;
            }
        }
    }
}
