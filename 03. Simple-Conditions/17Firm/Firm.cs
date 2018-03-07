using System;

class Firm
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());
        int staff = int.Parse(Console.ReadLine());

        //za proekta sa neobhodimi 90 chasa;
        // firmata razpolaga s 7 dena
        double time = (workDays * 0.9) * 8;

        double staffOver = staff * (2 * workDays);
        double AllHours = Math.Floor(time + staff);

        if ( AllHours >= hours)
        {
            double result = AllHours - hours;
            Console.WriteLine($"Yes!{result} hours left");
        }
        else if (hours > AllHours)
        {
            double result1 = hours - AllHours;
            Console.WriteLine($"Not enough time!{result1} hours needed");
        }



       









    }
}
