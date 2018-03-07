using System;

class PointOfBord
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool xyTop = x >= x1 && x <= x2 && y == y1;
        bool xyDown = x >= x1 && x <= x2 && y == y2;

        bool xyLeft = y >= y1 && y <= y2 && x == x1;
        bool xyRight = y >= y1 && y <= y2 && x == x2;

        if (xyDown || xyTop || xyRight || xyLeft)
        {

            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}

