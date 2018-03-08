using System;

class SumElement
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int biggestNumber = int.MinValue;
        int sum = 0;

        for (int i = 0; i < numbers; i++)
        {

            int customerNumber = int.Parse(Console.ReadLine());

            sum += customerNumber;

            if (customerNumber > biggestNumber)
            {
                biggestNumber = customerNumber ;

            }
            
        }


        if (biggestNumber == sum - biggestNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {biggestNumber}");
        }
        else
        {
            int difference = Math.Abs(biggestNumber - (sum - biggestNumber));

            Console.WriteLine("No");
            Console.WriteLine($"Diff = {difference}");

        }




    }
}

