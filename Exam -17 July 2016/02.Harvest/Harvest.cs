using System;

class Harvest
{
    static void Main()
    {
        //        •	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000];
        //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00];
        //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600];
        //•	4ти ред: брой работници – цяло число в интервала[1 … 20];

        int areaGrapes = int.Parse(Console.ReadLine());
        double grapesForKM = double.Parse(Console.ReadLine());
        int wineLiters = int.Parse(Console.ReadLine());
        int countOfWorkers = int.Parse(Console.ReadLine());

        double sumGrapes = areaGrapes * grapesForKM;
        double wine = (sumGrapes * 0.4) / 2.5;

        if (wine >= wineLiters)
        {
            double litersLeft = (wine - wineLiters);
            double litersForPerson = (wine - wineLiters)/countOfWorkers;


            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
            Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersForPerson)} liters per person.");
        }
        else
        {
            double litersLeft = Math.Abs(wine - wineLiters);

            Console.WriteLine($"It will be a tough winter! More {Math.Floor( litersLeft)} liters wine needed.");   
        }
    }
}

