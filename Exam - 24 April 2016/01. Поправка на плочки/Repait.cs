using System;

class Repait
{
    static void Main()
    {
        //   N – дължината на страна от площадката в интервала[1...100]
        //   W – широчината на една плочка в интервала[0.1...10.00]
        //L – дължината на една плочка в интервала[0.1...10.00]
        //  	М – широчината на пейката в интервала[0...10]
        // 	О – дължината на пейката в интервала[0...10]

        int SideLanding = int.Parse(Console.ReadLine());
        double widthTile = double.Parse(Console.ReadLine());
        double lenghthTile = double.Parse(Console.ReadLine());
        int weidhtBench = int.Parse(Console.ReadLine());
        int lenghtBench = int.Parse(Console.ReadLine());

        int areaLanding = SideLanding * SideLanding;
        int areaBench = weidhtBench * lenghtBench;

        int currentArea = areaLanding - areaBench;

        double areaTile = widthTile * lenghthTile;

        double needsTile = currentArea / areaTile;
        double needsTime = needsTile * 0.2;

        Console.WriteLine($"{needsTile:f2}");
        Console.WriteLine($"{needsTime:f2}");

    }

}