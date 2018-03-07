using System;

class InvalidNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        bool inRange = (num >= 100 && num <= 200) || num == 0;

        if (!inRange)
        {
            Console.WriteLine("invalid"); 
        }
    }
}

