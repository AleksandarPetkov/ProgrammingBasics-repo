using System;

class TrapezoitArea
{
    static void Main()
    {
        double b1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (b1 + b2) * h / 2 ;
        Console.WriteLine($"Trapezoit Area = {area}");


    }
}
