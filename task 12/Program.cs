using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("num of words:");
        int n = int.Parse(Console.ReadLine());

        string[] w = new string[n];

        for (int a = 0; a < n; a++)
        {
            Console.WriteLine($"word {a + 1}: ");
            w[a] = Console.ReadLine();
        }

        string lw = w[0];
        string sw = w[0];

        foreach (string ow in w)
        {
            if (ow.Length > lw.Length)
                lw = ow;
            if (ow.Length < sw.Length)
                sw = ow;
        }

        Console.WriteLine($"long word: {lw} (length: {lw.Length})");
        Console.WriteLine($"short word: {sw} (length: {sw.Length})");
    }
}

