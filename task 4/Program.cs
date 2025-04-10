using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("PLN:");
        double income = double.Parse(Console.ReadLine());
        double tax = 0;

        if (income < 10000)
            tax = income * 1;
        else if (income > 10001 || income < 30000)
            tax = income * 0.1;
        else if (income > 30001 || income < 100000)
            tax = income * 0.2;
        else if (income > 100000)
            tax = income * 0.3;

        double result = income - tax;
        Console.WriteLine("result: " + result);
    }
}


