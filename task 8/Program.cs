using System;

class Program
{
    static void Main()
    {
        Random rn = new Random();
        int rnum = rn.Next(1, 11);
        int num;
        do
        {
            Console.Write("1 to 10: ");
            num = int.Parse(Console.ReadLine());

            if (num < rnum)
                Console.WriteLine("try again");
            else if (num > rnum)
                Console.WriteLine("try again");

        } while (num != rnum);
        Console.WriteLine("you win");
    }
}
