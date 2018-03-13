using System;


class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int stars = n - 2;

        //Start 1
        for (int i = 1; i <= n-2; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("{0}\\ /{0}",new string('*',stars));
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', stars));

            }
        }
        //End 1

        //Start 2
        Console.WriteLine("{0}@",new string(' ',stars+1));
        //End 2

        //Start 3
        for (int i = 1; i <= n - 2; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', stars));
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', stars));

            }
        }

    }
}

