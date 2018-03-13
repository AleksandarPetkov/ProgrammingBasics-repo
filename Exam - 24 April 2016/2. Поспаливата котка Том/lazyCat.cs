using System;

class lazyCat
{
    static void Main()
    {
        int lazyDays = int.Parse(Console.ReadLine());

        int dayOff = lazyDays * 127;
        int workDay = (365 - lazyDays) * 63;
        int totalMinuts = dayOff + workDay;

        if (totalMinuts < 30000)
        {
            int totalTimeH = (30000 - totalMinuts)/ 60;
            int totalTimeM = (30000 - totalMinuts) % 60;
           

            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{totalTimeH} hours and {totalTimeM} minutes less for play");
        }
        else
        {
            int diffHH = Math.Abs(30000 - totalMinuts)/60;
            int diffMM = Math.Abs(30000 - totalMinuts)%60;

            
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{diffHH} hours and {diffMM} minutes more for play");
        }
    }
}

