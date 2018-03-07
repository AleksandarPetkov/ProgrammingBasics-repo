using System;

class Triangle
{
    static void Main()
    {
        for (int row = 1; row <= 10; row++)
        {
            Console.Write(new string('*', row));
            Console.WriteLine(row);
        }
}

