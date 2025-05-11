public class car
{
    public string m { get; set; }
    public engine e { get; set; }
    public wheel[] ws { get; set; }

    public car(string mark, engine engine, wheel[] wheels)
    {
        m = mark;
        e = engine;
        ws = wheels;
    }

    public static car copy(car ccaarr)
    {
        if (ccaarr == null) return null;

        engine ne = ccaarr.e.copy();

        wheel[] nw = new wheel[ccaarr.ws.Length];
        for (int a = 0; a < ccaarr.ws.Length; a++)
        {
            nw[a] = ccaarr.ws[a].copy();
        }

        return new car(ccaarr.m, ne, nw);
    }
}