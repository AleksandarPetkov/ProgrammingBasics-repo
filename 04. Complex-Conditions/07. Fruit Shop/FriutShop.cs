using System;

class FriutShop
{
    static void Main()
    {
        string friut = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price = -1;

       


        if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
        {
            if (friut == "banana")
            {
                price = 2.50 * quantity;
            }
            else if (friut == "apple")
            {
                price = 1.20 * quantity;
            }
            else if (friut == "orange")
            {
                price = 0.85 * quantity; 
            }
            else if (friut == "grapefruit")
            {
                price = 1.45 * quantity;
            }
            else if (friut == "kiwi")
            {
                price = 2.70 * quantity;
            }
            else if (friut == "pineapple")
            {
                price = 5.50 * quantity;
            }
            else if (friut == "grapes")
            {
                price = 3.85 * quantity;
            }
            
        }


        else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            if (friut == "banana")
            {
                price = 2.70 * quantity;
            }
            else if (friut == "apple")
            {
                price = 1.25 * quantity;
            }
            else if (friut == "orange")
            {
                price = 0.90 * quantity;
            }
            else if (friut == "grapefruit")
            {
                price = 1.60 * quantity;
            }
            else if (friut == "kiwi")
            {
                price = 3.0 * quantity;
            }
            else if (friut == "pineapple")
            {
                price = 5.60 * quantity;
            }
            else if (friut == "grapes")
            {
                price = 4.20 * quantity;
            }
            
        }

        if (price >= 0)
        {
            Console.WriteLine("{0:f2}",price);
        }
        else
        {
            Console.WriteLine("error");
        }
        

       
        
        

       
        

    }
}

