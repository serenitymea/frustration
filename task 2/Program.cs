using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c:");
        int c = int.Parse(Console.ReadLine());

        if ((a * a + c * c == b * b) ||
            (c * c + b * b == a * a) ||
            (a * a + b * b == c * c))

            Console.WriteLine("+");
        else
            Console.WriteLine("-");
    }
}
