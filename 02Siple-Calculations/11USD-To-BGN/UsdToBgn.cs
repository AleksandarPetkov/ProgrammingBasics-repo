using System;

class UsdToBgn
{
    static void Main()
    {
        
        double usd = double.Parse(Console.ReadLine());
        double result = usd * 1.79549;
        Console.WriteLine($"{result:f2}");
    }
}

