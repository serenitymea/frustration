class Program
{
    static void Main()
    {
        Figure[] fig = new Figure[2];
        fig[0] = new Rectangle(4, 5);
        fig[1] = new Square(3);

        foreach (var f in fig)
        {
            Console.WriteLine($"area: {f.a()}, perimeter: {f.p()}");
        }
    }
}