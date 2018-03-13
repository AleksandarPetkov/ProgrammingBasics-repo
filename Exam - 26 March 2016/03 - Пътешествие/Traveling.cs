using System;

class Traveling
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = string.Empty;
        string place = string.Empty;
        double expencive = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                place = "Camp";
                expencive = budget * 0.3;

            }
            else if (season == "winter")
            {
                place = "Hotel";
                expencive = budget * 0.7;
            }

        }
        else if (budget > 100 && budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                place = "Camp";
                expencive = budget * 0.4;

            }
            else if (season == "winter")
            {
                place = "Hotel";
                expencive = budget * 0.8;
            }
        }
        else if (budget > 1000)
        {
            destination = "Europe";
            place = "Hotel";
            expencive = budget * 0.9;

        }
        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} - {expencive:f2}");
    }
}


