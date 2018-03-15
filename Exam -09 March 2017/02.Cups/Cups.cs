using System;

class Cups
{
    static void Main()
    {
        //        •	Първи ред – броят чаши които трябва да се изработят – цяло число в интервала [1...10000]
        //•	Втори ред – броят работници – цяло число в интервала [1...1000]
        //•	Трети ред – работните дни – цяло число в интервала [1...1000]

        int countOfCups = int.Parse(Console.ReadLine());
        int countOfWorkers = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        double workingHourse = countOfWorkers * workingDays * 8.0;

        double production = Math.Floor(workingHourse / 5.0);

        if (production < countOfCups)
        {
            double diff = (countOfCups - production) * 4.2;
            Console.WriteLine($"Losses: {diff:f2}");
        }
        else if (production >= countOfCups)
        {
            double diff =Math.Abs(countOfCups - production) * 4.2;
            Console.WriteLine($"{diff:f2} extra money");

        }


    }
}

