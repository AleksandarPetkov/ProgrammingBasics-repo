using System;

class LeftAndRight
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());


        int sumLeft = 0;
        int sumRight = 0;


        for (int i = 0; i < numbers; i++)
        {
            int readingLeftSide = int.Parse(Console.ReadLine());

            sumLeft = sumLeft + readingLeftSide;
        }




        for (int i = 0; i < numbers; i++)
        {
            int readingRightSide = int.Parse(Console.ReadLine());

            sumRight = sumRight + readingRightSide;

        }

        if (sumRight == sumLeft)
        {
            Console.WriteLine($"Yes, sum = {sumLeft}");
        }
        else
        {
            int finallySum = Math.Abs(sumLeft - sumRight);

            Console.WriteLine($"No, diff = {finallySum}");
        }
    }

}

