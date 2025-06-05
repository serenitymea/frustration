class Square : Figure
{
    public double s { get; set; }

    public Square(double side)
    {
        s = side;
    }

    public override double a()
    {
        return s * s;
    }

    public override double p()
    {
        return 4 * s;
    }
}
