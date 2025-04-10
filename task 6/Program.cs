using System;

class Program
{
    static void Main()
    {
        Console.Write("number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(":");
        for (int a = 1; a <= 10; a++)
        {
            Console.WriteLine($"{num} x {a} = {num * a}");
        }
    }
}
