using System;

class Program
{
    static void Main()
    {
        Console.Write("all: ");
        int count = int.Parse(Console.ReadLine());

        double res = 0;

        for (int a = 0; a < count; a++)
        {
            Console.Write($"num {a + 1}: ");
            double num = double.Parse(Console.ReadLine());
            res += num;
        }

        double end = res / count;
        Console.WriteLine($": {end}");
    }
}
