using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Hello Learning03 World!***\n");

        // Fraction fraction = new Fraction();
        // fraction.SetTop(2);
        // fraction.SetBottom(3);
        // Console.WriteLine(fraction.GetTop());
        // Console.WriteLine(fraction.GetBottom());

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine();
    }
}