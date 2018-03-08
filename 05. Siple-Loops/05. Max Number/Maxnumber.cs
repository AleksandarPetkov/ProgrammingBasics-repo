using System;

class Maxnumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int maxNumber = int.MinValue;

        for (int i = 0; i < num; i++)
        {
            int costumerNum = int.Parse(Console.ReadLine());

            if (costumerNum > maxNumber)
            {
                maxNumber = costumerNum;
            }

        }

        Console.WriteLine(maxNumber);
    }
}

