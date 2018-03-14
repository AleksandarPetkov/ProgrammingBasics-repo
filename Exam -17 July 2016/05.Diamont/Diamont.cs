using System;

class Diamont
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Strart 1
        Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*',n*3));
        //End 1

        // Start 2
        int points = n - 1;
        int insidePoints = n * 3;

        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',points),new string('.',insidePoints));
            points--;
            insidePoints += 2;
        }
        //End 2

        //Start 3
        Console.WriteLine("{0}",new string('*',n*5));
        //End 3

        //Start 4
        int downPoints = 1;
        int downMiddlePoints = 5*n-4;
        for (int i = 0; i < n*2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',downPoints),new string('.',downMiddlePoints));
            downPoints++;
            downMiddlePoints -= 2;
        }
        //End 4

        //Start 5
        Console.WriteLine("{0}{1}{0}",new string('.',n*2+1),new string('*',n-2));
    }
}

