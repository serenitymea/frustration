using System;
class Program
{
    static void Main()
    {
        Bankomat bankomat = new Bankomat(1365, "8888", "name");
        bankomat.Zaloguj("name", "8888");
        bankomat.Wplac(573);
        bankomat.Wyplac(324);
        bankomat.WyswietlSaldo();
    }
}