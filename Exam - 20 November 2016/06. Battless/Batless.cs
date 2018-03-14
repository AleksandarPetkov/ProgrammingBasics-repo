using System;

class Batless
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int maxFights = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int a = 1; a <= secondPlayer; a++)
            {
               

                if (maxFights == counter)
                {
                    break;
                }
                Console.Write($"({i} <-> {a}) ");
                counter++;
            }
        }
    }
}

