using System;

class Program
{
    static void Main()
    {
        //  •	Първи ред – Цена за килограм зеленчуци – число с плаваща запетая
        // •	Втори ред – Цена за килограм плодове – число с плаваща запетая
        //•	Трети ред – Общо килограми на зеленчуците – цяло число
        //      •	Четвърти ред – Общо килограми на плодовете – цяло число


        double priceVegatable = double.Parse(Console.ReadLine());
        double priceFriut = double.Parse(Console.ReadLine());

        int kgVegateble = int.Parse(Console.ReadLine());
        int kgFriut = int.Parse(Console.ReadLine());

        double sumVegateble = priceVegatable * kgVegateble;
        double sumFriut = priceFriut * kgFriut;

        double inEuro = (sumFriut + sumVegateble)/1.94;
        Console.WriteLine(inEuro);
        
    }
}

