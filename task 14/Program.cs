using System;

class Program
{
    static void Main()
    {
        inp(out int ch, out double temp);

        if (ch == 1)
        {
            double result = ctf(temp);
            Console.WriteLine($"{temp}C = {result:F2}F");
        }
        else if (ch == 2)
        {
            double result = ftc(temp);
            Console.WriteLine($"{temp}F = {result:F2}C");
        }
    }
    static double ctf(double c)
    {
        return (c * 9 / 5) + 32;
    }
    static double ftc(double f)
    {
        return (f - 32) * 5 / 9;
    }
    static void inp(out int ch, out double temp)
    {
        Console.WriteLine("1 - c to f");
        Console.WriteLine("2 - f to c");
        Console.Write("1 or 2: ");
        ch = int.Parse(Console.ReadLine());

        Console.Write("temp: ");
        temp = double.Parse(Console.ReadLine());
    }

}
