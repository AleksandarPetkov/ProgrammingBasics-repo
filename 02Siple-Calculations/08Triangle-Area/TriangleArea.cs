using System;

class TriangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter a :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h :");
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2 ;
        Console.WriteLine($"{area:f2}");
                      
    
    }
}

