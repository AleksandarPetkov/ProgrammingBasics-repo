using System;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //start 1
        int points = n + 1;
        int dashes = n * 2 + 1;

        Console.WriteLine("{0}{1}{0}",new string('.',points),new string('_',dashes));
        //End 1

        //Start 2
        int counterpoints = n;
        int pointsInLoop = n * 2 - 1;
        for (int i = 1; i <=n ; i++)
        {
            Console.WriteLine(@"{0}//{1}\\{0}",new string('.',counterpoints),new string('_',pointsInLoop));
            counterpoints--;
            pointsInLoop = pointsInLoop + 2;

        }
        //End 2

        //Start 3
        Console.WriteLine(@"//{0}STOP!{0}\\",new string('_',n+n-3));
        //End 3
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(@"{0}\\{1}//{0}", new string('.', counterpoints), new string('_', pointsInLoop));
            counterpoints++;
            pointsInLoop = pointsInLoop - 2;

        }

    }
}

