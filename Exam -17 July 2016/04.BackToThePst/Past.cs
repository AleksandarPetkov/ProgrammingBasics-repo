
using System;

class Past
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double years = double.Parse(Console.ReadLine());

        int countYears = 17;
        

        for (int i = 1800; i <= years; i++)
        {
            countYears++;
            if (i % 2 == 0)
            {
                money = money - 12000;
            }
            else
            {
                double neshto = 12000 + 50 * countYears;
                money = money - neshto;
            }
        }

        if (money >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
        }
        else
        {
            double castMoney = Math.Abs(money);
            Console.WriteLine($"He will need {castMoney:f2} dollars to survive.");
        }
        
    }
}

