using System;

class CircleAreaAndPerimetar
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r ;
        double perimetar = 2 * Math.PI * r;
        Console.WriteLine($"Area =  {area}");
        Console.WriteLine($"Perimetar = {perimetar}");

    }
}

