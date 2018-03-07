using System;

class Campany
{
    static void Main()
    {
        int DaysCampany = int.Parse(Console.ReadLine());
        int NumbersSladkari = int.Parse(Console.ReadLine());
        int NumbersTorts = int.Parse(Console.ReadLine());
        int NumbersGofreti= int.Parse(Console.ReadLine());
        int NumbersPalachinki = int.Parse(Console.ReadLine());

        double priceTorta = NumbersTorts * 45;
        double priceGofreti = NumbersGofreti * 5.80;
        double pricePalachinki = NumbersPalachinki * 3.20;

        double sumPerDay = (priceGofreti + pricePalachinki + priceTorta) * NumbersSladkari ;
        double sumTotal = sumPerDay * DaysCampany;
        double SumAfterTax = sumTotal - (sumTotal * 0.125);  // << Дадена е дробно 1/8 , преобразувам в десетично
        Console.WriteLine(SumAfterTax);




    }
}

