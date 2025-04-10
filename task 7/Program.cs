class Program
{
    static void Main()
    {
        int res = 0;
        while (true)
        {
            Console.Write("number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                break;

            res += num;
        }
        Console.WriteLine(":" + res);
    }
}