using System;

class Tickets
{
    static void Main()
    {
        //        •	На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
        //•	На втория ред е категорията – „VIP” или „Normal”
        //•	На третия ред е броят на хората в групата – цяло число в интервала[1... 200]

        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        double CountOfGroup = double.Parse(Console.ReadLine());

        double priceTicket = 0;
        double sumTicket = 0;
        double leftBudget = 0;

        if (category == "VIP")
        {
            priceTicket = 499.99;
        }
        else if(category == "Normal")
        {
            priceTicket = 249.99;
        }

        if (CountOfGroup >= 1 && CountOfGroup <= 4)
        {
            leftBudget  = budget - (budget * 0.75);
            
        }
        else if (CountOfGroup >=5 && CountOfGroup <= 9)
        {
             leftBudget = budget - (budget * 0.60);

        }
        else if (CountOfGroup >= 10 && CountOfGroup <= 24)
        {
            leftBudget = budget - (budget * 0.50);

        }
        else if (CountOfGroup > 24 && CountOfGroup <= 49)
        {
           leftBudget = budget - (budget * 0.40);

        }
        else if (CountOfGroup > 49)
        {
             leftBudget = budget - (budget * 0.25);

        }
        sumTicket = priceTicket * CountOfGroup;

        if (sumTicket <= leftBudget)
        {
            double diff = leftBudget - sumTicket;
            Console.WriteLine($"Yes! You have {diff:f2} leva left.");
        }
        else
        {
            double diff = Math.Abs( leftBudget - sumTicket);

            Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
        }


    }
}

