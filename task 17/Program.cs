using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {

        string[] pun = { "aoopl", "alpl", "akkpl" };
        Random rn = new Random();
        int r = rn.Next(pun.Length);
        char[] rw = pun[r].ToCharArray();


        Console.WriteLine("type letter:");
        string inp = Console.ReadLine();
        int att = rw.Length * 2;
        while (att != 0)
        {
            char a = inp[0];
            if (inp.Length == 1)
            {
            
                Console.WriteLine("you letter: " + a);
            }
            else
            {
                Console.WriteLine("error");
                break;
            }

            Console.WriteLine(string.Join(" ", rw));

            int i = 0;
            while (i < rw.Length && rw[i] != a)
            {
                if (true)
                {
                    Console.WriteLine("you right");
                    return;
                }
                else
                {
                 int fatt = att -= 1;
                Console.WriteLine("NO, your attemps:" + fatt);
                    return;
                }
            }
        }
    }
}


