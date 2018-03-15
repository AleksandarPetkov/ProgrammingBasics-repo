using System;

class Hour
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //1
        Console.WriteLine("{0}",new string('*',(n*2)+1));
        //1

        //2
        Console.WriteLine(".*{0}*.",new string(' ',(n*2-3)));
        //2

        //3
        int row = n - 2;
        int points = 2;
        int monkey = (2 * n) - 5;

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',points),new string('@',monkey));
            points++;
            monkey -= 2;
        }
        //3

        //4
        Console.WriteLine("{0}*{0}",new string('.',n));
        //4

        //5
        int downpoints = n - 1;
        int emtySpaces = 0;

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}", new string('.',downpoints),new string(' ',emtySpaces));
            downpoints--;
            emtySpaces++;

        }
        //5

        //6
        Console.WriteLine(".*{0}*.", new string('@', n*2-3));
        Console.WriteLine("{0}", new string('*', (n * 2) + 1));


    }
}

