using System;

class OddOrEvenSum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddsSum = 0;

        for (int i = 0; i < num ; i++)
        {
            int customerNum = int.Parse(Console.ReadLine());

            if (i % 2 == 0)                          // Проверява се местата на числата , а не тяхната стойност!!!
            {                                        //сумата от числата на четни позиции  и сумата на сумата на числата на нечетни позиции.
                evenSum = evenSum + customerNum;

            }
            else
            {
                oddsSum += customerNum;
            }

            

        }

        if (evenSum == oddsSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {

            int totalSum = Math.Abs(oddsSum - evenSum);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {totalSum}");
        }
    }
}

