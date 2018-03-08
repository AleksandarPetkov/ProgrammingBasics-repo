using System;

class MinNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue;

        for (int i = 0; i < num; i++)
        {
            int costumerNumber = int.Parse(Console.ReadLine());

            if (costumerNumber < minNumber)
            {
                minNumber = costumerNumber ;
            }


        }

        Console.WriteLine(minNumber);
    }
}

