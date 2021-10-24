using System;

namespace calculatorDereza
{
    public class Fraction
    {
        public float numerator;
        public float denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 0;
        }
        public string GetSum(Fraction num1, Fraction num2,  string sign)
        {
            float sum = 0;
            Fraction num3 = new Fraction();
            if (sign == "+")
            {
                num3.denominator = num1.denominator * num2.denominator;
                num3.numerator = num1.numerator * num2.denominator + num2.numerator * num1.denominator;
                sum = num3.numerator / num3.denominator;
            }
            if (sign == "-")
            {
                num3.denominator = num1.denominator * num2.denominator;
                num3.numerator = num1.numerator * num2.denominator - num2.numerator * num1.denominator;
                sum = num3.numerator / num3.denominator;
            }
            if (sign == "*")
            {
                num3.numerator = num1.numerator * num2.numerator;
                num3.denominator = num1.denominator * num2.denominator;
                sum = num3.numerator / num3.denominator;
            }
            if (sign == "/")
            {
                num3.numerator = num1.numerator * num2.denominator;
                num3.denominator = num1.denominator * num2.numerator;
                sum = num3.numerator / num3.denominator;
            }
            string result = String.Format("{0:f3}", sum);

            return result;
        }

        public Fraction GetReduction(Fraction num1)
        {
            float num = num1.numerator;
            float den = num1.denominator;
            while (den != 0)
            {
                var t = den;
                den = num % den;
                num = t;
            }
            int maxdel = (int)num;
            num1.numerator = num1.numerator / maxdel;
            num1.denominator = num1.denominator / maxdel;
            
            return num1;
        }

        public string GetCompare(Fraction num1, Fraction num2)
        {
            string resultSign = "";
            if (num1.numerator * num2.denominator < num2.numerator * num1.denominator)
            {
                resultSign = "<";
            }
            if (num1.numerator * num2.denominator > num2.numerator * num1.denominator)
            {
                resultSign = ">";
            }
            if (num1.numerator * num2.denominator == num2.numerator * num1.denominator)
            {
                resultSign = "=";
            }
            return resultSign;
        }
    }
}
