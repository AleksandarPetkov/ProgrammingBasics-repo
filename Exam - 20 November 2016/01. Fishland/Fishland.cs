using System;

class Fishland
{
    static void Main()
    {
        //        •	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
        //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
        //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
        //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
        //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]

        double priceSkumria = double.Parse(Console.ReadLine());
        double priceCaca = double.Parse(Console.ReadLine());
        double KgPalamud = double.Parse(Console.ReadLine());
        double KgSafrid = double.Parse(Console.ReadLine());
        double KgMidi = double.Parse(Console.ReadLine());

        double pricePalamud = priceSkumria + (priceSkumria * 0.60);
        double sumPalamud = pricePalamud * KgPalamud;

        double priceSafrid = priceCaca + (priceCaca * 0.80);
        double sumSafrid = priceSafrid * KgSafrid;

        double sumMidi = KgMidi * 7.50;

        double total = sumMidi + sumPalamud + sumSafrid;
        Console.WriteLine($"{total:f2}");
    }
}

