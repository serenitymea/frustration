using System;

class Program
{
    static void Main()
    {
        string[] words = { "apple", "banana", "orange" };
        Random random = new Random();
        int iii = random.Next(words.Length);
        char[] tw = words[iii].ToCharArray();
        bool[] gu = new bool[tw.Length];

        int att = tw.Length * 2;

        while (att > 0)
        {
            Console.WriteLine("\nguess a letter:");
            string input = Console.ReadLine();

            if (input.Length != 1)
            {
                Console.WriteLine("error");
                continue;
            }

            char l = input[0];
            bool f = false;

            for (int a = 0; a < tw.Length; a++)
            {
                if (tw[a] == l)
                {
                    gu[a] = true;
                    f = true;
                }
            }

            if (f)
            {
                Console.WriteLine("right");
            }
            else
            {
                att--;
                Console.WriteLine("NO att: " + att);
            }

            for (int a = 0; a < tw.Length; a++)
            {
                Console.Write(gu[a] ? tw[a] + " " : "_ ");
            }
            Console.WriteLine();

            if (ag(gu))
            {
                Console.WriteLine("you win");
                break;
            }
        }

        if (!ag(gu))
        {
            Console.WriteLine("loser w: " + new string(tw));
        }
    }

    static bool ag(bool[] gu)
    {
        foreach (bool g in gu)
        {
            if (!g) return false;
        }
        return true;
    }
}
