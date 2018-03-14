using System;

class Pets
{
    static void Main()
    {
        //        •	Първи ред – брой дни – цяло число в интервал[1…5000]
        //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
        //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
        //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
        //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00

        int countOfDays = int.Parse(Console.ReadLine());
        double allFood = double.Parse(Console.ReadLine());
        double foodDog = double.Parse(Console.ReadLine());
        double foodCat = double.Parse(Console.ReadLine());
        double foodTurtleInGrams = double.Parse(Console.ReadLine());

        double totalDogFood = countOfDays * foodDog;

        double totalCatFood = countOfDays * foodCat;

        double totalTurtleFood = countOfDays * (foodTurtleInGrams / 1000);

        double TotalFood = totalCatFood + totalDogFood + totalTurtleFood;

        if (TotalFood <= allFood )
        {
            double diff = Math.Abs(TotalFood - allFood);

            Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
        }
        else
        {
            double diff = Math.Abs(TotalFood - allFood);

            Console.WriteLine($"{Math.Ceiling( diff)} more kilos of food are needed.");

        }
    }
}
