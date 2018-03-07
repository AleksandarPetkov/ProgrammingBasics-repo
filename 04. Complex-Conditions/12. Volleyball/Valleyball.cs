using System;

class Valleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int hollyday = int.Parse(Console.ReadLine());
        int weekendsHisCity = int.Parse(Console.ReadLine());

        double weekendsForyear = 48 - weekendsHisCity;

        double weekensInSofia = weekendsForyear * 0.75;

        double hollydayPlayning = hollyday * (2 / 3.00);

        double sumPlaining = weekensInSofia + weekendsHisCity + hollydayPlayning;

        double addPlayngTime = sumPlaining * 0.15;


        if (year == "normal")
        {
            Console.WriteLine(Math.Floor(sumPlaining));
        }

        else if (year == "leap")
        {
            Console.WriteLine(Math.Floor(sumPlaining + addPlayngTime));
        }



        
    }
}

