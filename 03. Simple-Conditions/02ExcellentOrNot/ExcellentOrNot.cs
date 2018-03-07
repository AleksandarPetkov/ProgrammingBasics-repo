using System;

class ExcellentOrNot
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        if (num >= 5.5)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}

