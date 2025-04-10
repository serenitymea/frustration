using System;

namespace vagina
{
    class Program
    {
        static void Main()
        {
            p("vagina");

            sum(9, 7);

            sa(6, 8, 10, 12, 14, 16, 18);
        }
        public static void p(object jopa)
        {
            Console.WriteLine(jopa);
        }
        public static void sum(int x, int y)
        {
            int res = x + y;
            Console.WriteLine("res:" + res);
        }
        public static double sa(params int[] numbers)
        {
            double total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            double ress = total / numbers.Length;
            Console.WriteLine("res:" + ress);
            return ress;
        }
    }
}
