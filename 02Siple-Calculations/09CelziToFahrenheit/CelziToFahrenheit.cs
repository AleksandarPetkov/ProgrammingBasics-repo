using System;

class CelziToFahrenheit
{
    static void Main()
    {
        
        double c = double.Parse(Console.ReadLine());
        double sum = c * 1.8 + 32;
        Console.Write($"{sum:f2}");
    
    }
}
