using System;

class Program
{
    static void Main()
    {
        //•	На първия ред – броят биткойни. Цяло число в интервала[0…20]
        // •	На втория ред – броят китайски юана.Реално число в интервала[0.00… 50 000.00]
        //•	На третия ред – комисионната.Реално число в интервала[0.00... 5.00]

        int bitCoin = int.Parse(Console.ReadLine());
        double iena = double.Parse(Console.ReadLine());
        double commision = double.Parse(Console.ReadLine());

        double BitCointInLeva = bitCoin * 1168;

        double ienaInDolars = iena * 0.15;
        double ienaInLeva = ienaInDolars * 1.76;

        double sumPricesInEuro = (BitCointInLeva + ienaInLeva) / 1.95 ;

        double comissionInProcent = commision / 100;
        double comissionInEuro = sumPricesInEuro * comissionInProcent;

        double resul = sumPricesInEuro - comissionInEuro;
        Console.WriteLine($"{resul:f2}");
    }
}

