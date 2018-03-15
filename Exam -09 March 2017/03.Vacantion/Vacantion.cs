using System;

class Vacantion
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string location = string.Empty;
        string place = string.Empty;

        if (budget <= 1000)
        {
            location = "Camp";

            if (season == "Summer")
            {
                place = "Alaska";
                budget = budget * 0.65;
            }
            else if (season == "Winter")
            {
                place = "Morocco";
                budget = budget * 0.45;
            }
                  
        }

        else if (budget > 1000 && budget <= 3000)
        {
            location = "Hut";

            if (season == "Summer")
            {
                place = "Alaska";
                budget = budget * 0.80;
            }
            else if (season == "Winter")
            {
                place = "Morocco";
                budget = budget * 0.60;
            }

        }
        else if (budget > 3000)
        {
            location = "Hotel";

            if (season == "Summer")
            {
                place = "Alaska";
                budget = budget * 0.90;
            }
            else if (season == "Winter")
            {
                place = "Morocco";
                budget = budget * 0.90;
            }

        }

        Console.WriteLine($"{place} - {location} - {budget:f2}");
    }
}

