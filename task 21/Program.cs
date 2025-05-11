using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("task 1\n");
        Console.WriteLine(tsk1("Apple"));
        Console.WriteLine(tsk1("Pineapple"));
        Console.WriteLine(tsk1("Orange"));

        Console.WriteLine("\ntask 2\n");
        string phr = "Music is the soul of language";
        string res2 = tsk2(phr);
        Console.WriteLine(res2);

        Console.WriteLine("\ntask 3\n");
        Console.WriteLine(kebtocam("music-is-the-soul-of-language"));
        Console.WriteLine(camtokeb("MusicIsTheSoulOfLanguage"));

        Console.WriteLine("\ntask 4\n");
        BuildWithString();
        BuildWithStringBuilder();
    }

    static string tsk1(string w)
    {
        int mid = w.Length / 2;

        if (w.Length % 2 == 0)
        {
            return w.Substring(mid - 1, 2);
        }
        else
        {
            return w.Substring(mid, 1);
        }
    }
    static string tsk2(string phrr)
    {
        string[] ww = phrr.Split(' ');
        Array.Reverse(ww);
        return string.Join(" ", ww);
    }
    static string camtokeb(string t)
    {
        string res = "";

        for (int i = 0; i < t.Length; i++)
        {
            char ch = t[i];

            if (char.IsUpper(ch))
            {
                if (i != 0)
                {
                    res += "-";
                }

                res += char.ToLower(ch);
            }
            else
            {
                res += ch;
            }
        }

        return res;
    }

    static string kebtocam(string t)
    {
        string res = "";
        bool bl = false;

        for (int i = 0; i < t.Length; i++)
        {
            char ch = t[i];

            if (i == 0)
            {
                res += char.ToUpper(ch);
            }
            else if (ch == '-')
            {
                bl = true;
            }
            else if (bl)
            {
                res += char.ToUpper(ch);
                bl = false;
            }
            else
            {
                res += ch;
            }
        }

        return res;
    }
    static void BuildWithString()
    {
        Stopwatch sw = Stopwatch.StartNew();

        string t = "";
        for (int i = 1; i <= 100000; i++)
        {
            t += i;
        }

        sw.Stop();
        Console.WriteLine("String");
        Console.WriteLine($"time: {sw.Elapsed}");
    }
    static void BuildWithStringBuilder()
    {
        Stopwatch sw = Stopwatch.StartNew();

        StringBuilder res = new StringBuilder();
        for (int i = 1; i <= 100000; i++)
        {
            res.Append(i);
        }

        sw.Stop();
        Console.WriteLine("StringBuilder");
        Console.WriteLine($"time: {sw.Elapsed}");
    }

}

