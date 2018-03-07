using System;

class RadiansToDegrees
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double result = rad * 180 / Math.PI;
        Console.WriteLine(Math.Round(result));
    }
}

