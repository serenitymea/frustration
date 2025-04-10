using System;

class Program
{
    static void Main()
    {
        string[] snum = { "4", "6", "8" };

        int[] inum = new int[snum.Length];

        for (int a = 0; a < snum.Length; a++)
        {
            inum[snum.Length - 1 - a] = int.Parse(snum[a]);
        }

        Console.WriteLine("[" + string.Join(", ", inum) + "]");
    }
}

