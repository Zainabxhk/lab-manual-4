using System;

namespace Lab3Q2
{
    class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void Display()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }
    }
}