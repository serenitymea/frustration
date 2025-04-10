using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("number:");
        double number = double.Parse(Console.ReadLine());
        if (number > 0)
            Console.WriteLine("+");
        else if (number < 0)
            Console.WriteLine("-");
        else
            Console.WriteLine("0");
    }
}
