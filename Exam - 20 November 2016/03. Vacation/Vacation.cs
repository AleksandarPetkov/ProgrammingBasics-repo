using System;

class Vacation
{
    static void Main()
    {
        //        •	Първият ред – броят възрастни хора.Цяло число в интервала[1…100]
        //•	Вторият ред – броят ученици. Цяло число в интервала[1… 100]
        //•	Третият ред – броят нощувки. Цяло число в интервала[1... 60]
        //•	Четвъртият ред – вид транспорт – “train”, “bus”, “boat” или “airplane”

        int countOldPeople = int.Parse(Console.ReadLine());
        int countScoolGues = int.Parse(Console.ReadLine());
        int countOfNights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        double ticketPriceOldMan = 0;
        double ticketPriceScoolGues = 0;
        double countAllgroup = countOldPeople + countScoolGues;

        if (transport == "train")
        {
            ticketPriceOldMan = 24.99;
            ticketPriceScoolGues = 14.99;

            if (countAllgroup >= 50)
            {
                ticketPriceOldMan = 24.99 / 2;
                ticketPriceScoolGues = 14.99 / 2;
            }
        }
        else if (transport == "bus")
        {
            ticketPriceOldMan = 32.50;
            ticketPriceScoolGues = 28.50;
        }
        else if (transport == "boat")
        {
            ticketPriceOldMan = 42.99;
            ticketPriceScoolGues = 39.99;
        }
        else if (transport == "airplane")
        {
            ticketPriceOldMan = 70.00;
            ticketPriceScoolGues = 50.00;
        }

        double transportCosts = (countOldPeople * ticketPriceOldMan + countScoolGues * ticketPriceScoolGues)*2;

        double hotelCosts = countOfNights * 82.99;

        double comission = (transportCosts + hotelCosts) * 0.10;

        double allPrice = transportCosts + hotelCosts + comission;
        Console.WriteLine($"{allPrice:f2}");
    }
}

