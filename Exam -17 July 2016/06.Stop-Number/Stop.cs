using System;

class Stop
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());


        for (int i = start; i >= num; i--)
        {
            if (i == stop && i % 2 == 0 && i % 3 == 0)
            {
                break;
            }

            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

