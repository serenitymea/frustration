using System;

class Program
{
    static void Main()
    {
        double a = GetValue("a");
        double b = GetValue("b");
        double c = GetValue("c");
        double delta = CalculateDelta(a, b, c);
        QuadraticResult(delta, a, b, c);
    }

    static double GetValue(string name, double defV = 0)
    {
        Console.WriteLine($"{name}: ");
        string input = Console.ReadLine();
        return double.TryParse(input, out double result) ? result : defV;
    }

    static double CalculateDelta(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    static void QuadraticResult(double delta, double a, double b, double c)
    {
        Console.WriteLine($"Wnres: {a}x^2 + {b}x + {c} = 0");
        if (delta < 0)
        {
            Console.WriteLine("XXXXXX");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"x= {x}");
        }
        else
        {
            double sd = Math.Sqrt(delta);
            double x1 = (-b - sd) / (2 * a);
            double x2 = (-b + sd) / (2 * a);
            Console.WriteLine($"x1={x1}");
            Console.WriteLine($"x2={x2}");
        }
    }
}

