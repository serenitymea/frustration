using System;

class Program
{
    static void Main()
    {
        engine engine1 = new engine(150, "petrol");
        wheel[] wheels1 = new wheel[]
        {
            new wheel(16),
            new wheel(16),
            new wheel(16),
            new wheel(16)
        };
        car car1 = new car("Toyota", engine1, wheels1);
        car copycar1 = car.copy(car1);

        Console.WriteLine($"original: {car1.m}, {car1.e.t}, {car1.e.p}HP, tire size: {car1.ws[0].s}");
        Console.WriteLine($"copy: {copycar1.m}, {copycar1.e.t}, {copycar1.e.p}HP, tire size: {copycar1.ws[0].s}");
    }
}
