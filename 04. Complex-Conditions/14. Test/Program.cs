using System;

class Program
{
    static void Main()
    {
         double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double moneySpend = 0.0;

        if (budget <= 100)
        {
            Console.WriteLine("Somewhere in Bulgaria");
            if (season == "summer")
            {
                moneySpend = budget * 0.30;
                Console.WriteLine($"Camp - {moneySpend:f2}");
            }
            else
            {
                moneySpend = budget * 0.70;
                Console.WriteLine($"Hotel - {moneySpend:f2}");
            }
           
        }
        else if (budget <=1000)
        {
            Console.WriteLine("Somewhere in Balkans");
            if (season == "summer")
            {
                moneySpend = budget * 0.40;
                Console.WriteLine($"Camp - {moneySpend:f2}");
            }
            else
            {
                moneySpend = budget * 0.80;
                Console.WriteLine($"Hotel - {moneySpend:f2}");
            }
        }
        else if (budget > 1000)
        {
            Console.WriteLine("Somewhere in Europe");

            
            if (season == "summer" ||season == "winter")
            {
                moneySpend = budget * 0.90;
                Console.WriteLine($"Hotel - {moneySpend:f2}");
            }
            
            
        }
    }
}
