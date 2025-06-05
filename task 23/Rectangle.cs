class Rectangle : Figure
{
    public double l { get; set; }
    public double w { get; set; }

    public Rectangle(double length, double width)
    {
        l = length;
        w = width;
    }

    public override double a()
    {
        return l * w;
    }

    public override double p()
    {
        return 2 * (l + w);
    }
}