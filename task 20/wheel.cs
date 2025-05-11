public class wheel
{
    public int s { get; set; }

    public wheel(int size)
    {
        s = size;
    }
    public wheel copy()
    {
        return new wheel(s);
    }
}