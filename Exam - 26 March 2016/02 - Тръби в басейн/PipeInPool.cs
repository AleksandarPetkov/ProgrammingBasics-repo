using System;

class PipeInPool
{
    static void Main()
    {
        //•	Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала[1…10000].
        //•	Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].
        //•	Четвъртият ред съдържа числото H – часовете които работникът отсъства – число с плаваща запетая в интервала[1.0…24

        int volumePool = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());

        double missingTime = double.Parse(Console.ReadLine());

        double p1Full = p1 * missingTime;
        double p2Full = p2 * missingTime;
        double bothPipeFull = p1Full + p2Full;

        if (bothPipeFull <= volumePool)
        {
           double procentVolumePool = (bothPipeFull / volumePool)*100;
           double procentP1 = (p1Full / bothPipeFull) * 100;
           double procentP2 = (p2Full / bothPipeFull) * 100;


            Console.WriteLine($"The pool is {Math.Truncate(procentVolumePool)}% full. Pipe 1: {Math.Truncate(procentP1)}%. Pipe 2: {Math.Truncate(procentP2)}%.");
        }
        else
        {
            double overflows = Math.Abs(volumePool - bothPipeFull);

            Console.WriteLine($"For {missingTime} hours the pool overflows with {overflows:f1} liters.");
        }
    }
}

