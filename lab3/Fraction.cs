using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace lab3
{
    public class Fraction
    {
        int whole { get; set; }
        int numerator{ get; set; }
        int denominator { get; set; }

        public Fraction(int whole, int numerator, int denominator)
        {
            this.whole = whole;
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.whole + b.whole, a.numerator + b.numerator, a.denominator + b.denominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.whole - b.whole, a.numerator - b.numerator, a.denominator - b.denominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.whole * b.whole, a.numerator * b.numerator, a.denominator * a.denominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.whole / b.whole, a.numerator / b.numerator, a.denominator / a.denominator);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.whole == b.whole && a.numerator == b.numerator && a.denominator ==  a.denominator)
            { return true; }
            return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.whole != b.whole || a.numerator != b.numerator || a.denominator != a.denominator)
            { return true; }
            return false; ;
        }
        public override string ToString()
        {
            return whole + "  " + numerator + "/" + denominator;
        }
    }
}
