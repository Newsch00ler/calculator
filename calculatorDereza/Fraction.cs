using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction num3 = new Fraction();

            num3.denominator = num1.denominator * num2.denominator;
            num3.numerator = num1.numerator * num2.denominator + num2.numerator * num1.denominator;
            return num3;
        }
        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction num3 = new Fraction();

            num3.denominator = num1.denominator * num2.denominator;
            num3.numerator = num1.numerator * num2.denominator - num2.numerator * num1.denominator;
            if (num3.numerator == 0)
            {
                num3.denominator = 0;
            }
            return num3;
        }
        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction num3 = new Fraction();

            num3.denominator = num1.denominator * num2.denominator;
            num3.numerator = num1.numerator * num2.numerator;
            return num3;
        }
        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction num3 = new Fraction();

            num3.denominator = num1.denominator * num2.numerator;
            num3.numerator = num1.numerator * num2.denominator;
            if (num3.numerator == num3.denominator)
            {
                num3.denominator = 1;
                num3.numerator = 1;
            }
            return num3;
        }

        public Fraction GetReduction(Fraction num1)
        {
            float num = this.numerator;
            float den = this.denominator;
            while (den != 0)
            {
                var t = den;
                den = num % den;
                num = t;
            }
            int maxdel = (int)num;
            num1.numerator = numerator / maxdel;
            num1.denominator = denominator / maxdel;

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
