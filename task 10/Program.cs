using System;

class Program
{
    static void Main()
    {
        int[] num = { -2, 8, 4, -8, 3, -6 };

        int pres = 0;

        foreach (int n in num)
        {
            if (n > 0)
            {
                pres += n;
            }
        }

        Console.WriteLine("result: " + pres);
    }
}
