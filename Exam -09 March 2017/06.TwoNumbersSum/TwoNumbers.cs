using System;

class TwoNumbers
{
    static void Main()
    {
        //        •	Първи ред – начало на интервала – цяло число в интервала[1...1000]
        //•	Втори ред – край на интервала – цяло число в интервала[по - малко от първото число...1]
        //•	Трети ред – магическото число – цяло число в интервала[1...10000]

        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = start; i >= stop; i--)
        {
            for (int j = start; j >= stop; j--)
            {
                double sum = i + j;
                counter++;
                if (sum == magicNumber)
                {
                    Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                    
                    return;
                }
                

                
            }
        }
        Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");



    }
}

