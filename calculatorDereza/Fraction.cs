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
            string result = "";
            float num;
            float den;
            if (sign == "+")
            {
                den = num1.denominator * num2.denominator;
                num = num1.numerator * num2.denominator + num2.numerator * num1.denominator;
                result = String.Format("{0:f3}", num / den);
            }
            if (sign == "-")
            {
                den = num1.denominator * num2.denominator;
                num = num1.numerator * num2.denominator - num2.numerator * num1.denominator;
                result = String.Format("{0:f3}", num / den);
            }
            if (sign == "*")
            {
                num = num1.numerator * num2.numerator;
                den = num1.denominator * num2.denominator;
                result = String.Format("{0:f3}", num / den);
            }
            if (sign == "/")
            {
                num = num1.numerator * num2.denominator;
                den = num1.denominator * num2.numerator;
                result = String.Format("{0:f3}", num / den);
            }

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
