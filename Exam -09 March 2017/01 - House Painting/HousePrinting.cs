using System;

class HousePrinting
{
    static void Main()
    {
        double heightHouse = double.Parse(Console.ReadLine());
        double lenghtSideA = double.Parse(Console.ReadLine());
        double heightRoof= double.Parse(Console.ReadLine());

        double areaSide = heightHouse * lenghtSideA;

        double windows = 2.25;

        double areaTwoSides = (areaSide * 2) - (2 * windows);

        double backWall = heightHouse * heightHouse;
       
        double entrance = 2 * 1.2;
        double bothSide = (backWall * 2) - entrance;

        double allHouseArea = areaTwoSides + bothSide;
        double greenPaint = allHouseArea / 3.4;

        double squareRoof = 2 * (heightHouse * lenghtSideA);
        double triangleRoof = 2 * (heightHouse * heightRoof / 2);
        double allRoofArea = squareRoof + triangleRoof;
        double redPaint = allRoofArea / 4.3;

        Console.WriteLine($"{greenPaint:f2}");
        Console.WriteLine($"{redPaint:f2}");

    }
}

