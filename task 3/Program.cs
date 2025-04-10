using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1:");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("2:");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("choose:");
        Console.WriteLine("1 - (+)");
        Console.WriteLine("2 - (-)");
        Console.WriteLine("3 - (/)");
        Console.WriteLine("4 - (*)");
        Console.WriteLine(":");
        int choise = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        if (choise == 1)
            Console.WriteLine(n1 + n2);

        else if (choise == 2)
            Console.WriteLine(n1 - n2);

        else if (choise == 3)
            Console.WriteLine(n1 / n2);

        else if (choise == 4)
            Console.WriteLine(n1 * n2);
        Console.WriteLine(81 - (4 * 8 + 43));
    }
}