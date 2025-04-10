using System;

class Program
{
    static void Main()
    {
        int[,] m = new int[3, 3];

        Console.WriteLine("num for matrix:");

        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine($"num for pos [{a + 1},{b + 1}]: ");
                m[a, b] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("matrix:");
        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine(m[a, b]);
            }
            Console.WriteLine();
        }

        int det = m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
                        - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
                        + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        Console.WriteLine($"det: {det}");
    }
}

