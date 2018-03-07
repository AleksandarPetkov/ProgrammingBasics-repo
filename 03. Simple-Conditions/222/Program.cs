using System;

using System;

class Exams1
{
    static void Main()
    {
        double priceUiski = double.Parse(Console.ReadLine());
        double Beer = double.Parse(Console.ReadLine());
        double Vine = double.Parse(Console.ReadLine());
        double Rakiq  = double.Parse(Console.ReadLine());
        double uiski = double.Parse(Console.ReadLine());


        double priceRakiq = priceUiski / 2;
        double priceVine = priceRakiq * 0.6;
        double priceBeer = priceRakiq * 0.2;

        double sum = (priceUiski * uiski) + (Beer * priceBeer) + (Rakiq * priceRakiq) + (Vine * priceVine);

        Console.WriteLine($"{sum:f2}");



    }
}



