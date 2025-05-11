public class engine
{
    public int p { get; set; }
    public string t { get; set; }

    public engine(int power, string type)
    {
        p = power;
        t = type;
    }
    public engine copy()
    {
        return new engine(p, t);
    }
}

