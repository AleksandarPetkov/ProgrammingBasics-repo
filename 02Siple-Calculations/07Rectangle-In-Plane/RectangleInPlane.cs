using System;

class RectangleInPlane
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1= double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double height = Math.Abs(x2 - x1);
        double witgh = Math.Abs(y2 - y1);
        double area = height * witgh ;
        double perimeter = 2 * (height + witgh);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);



    }
}

