using System;

class del
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;

        double counterSum = 0.0;


        for (int i = 1; i <= n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            counterSum++;

            if (numbers % 2 == 0)
            {
                counter1++;
            }
            if (numbers % 3 == 0)
            {
                counter2++;

            }
            if (numbers % 4 == 0)
            {
                counter3++;
            }
        }


        Console.WriteLine($"{(counter1 / counterSum) * 100:f2}%");
        Console.WriteLine($"{(counter2 / counterSum) * 100:f2}%");
        Console.WriteLine($"{(counter3 / counterSum) * 100:f2}%");

    }
}

