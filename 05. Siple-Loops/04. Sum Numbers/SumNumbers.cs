using System;

class SumNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= num; i++)
        {
            int otherNum = int.Parse(Console.ReadLine());

            sum = sum + otherNum;
        }

        Console.WriteLine(sum);

    }

}


