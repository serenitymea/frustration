public class Bankomat
{
    private double saldo;
    private string haslo;
    private string login;
    private bool czyZalogowany;

    public double Saldo
    {
        get
        {
            return czyZalogowany ? saldo : 0;
        }
    }

    public string Login
    {
        get
        {
            return login;
        }
    }

    public Bankomat()
    {
        saldo = 0;
        haslo = "test";
        login = "test";
    }

    public Bankomat(double saldo, string haslo, string login)
    {
        this.saldo = saldo;
        this.haslo = haslo;
        this.login = login;
    }

    public void Zaloguj(string login, string haslo)
    {
        czyZalogowany = this.login == login && this.haslo == haslo;
        Console.WriteLine(czyZalogowany ? "" : "error");
    }

    public void Wplac(double sum)
    {
        if (czyZalogowany)
            saldo += sum;
    }

    public void Wyplac(double sum)
    {
        if (czyZalogowany && sum <= saldo)
            saldo -= sum;
    }

    public void WyswietlSaldo()
    {
        Console.WriteLine(czyZalogowany ? $"saldo: {saldo}" : "");
    }
}

