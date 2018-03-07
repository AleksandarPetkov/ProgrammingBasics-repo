using System;


class MetrixConverter2
{

    private static double value;
    private static string inpMetrics, outpMetrics;

    static void Main()
    {

        //try-catch-finally конструкция за да обработи грешка при въвеждането.
        try
        {

            value = double.Parse(Console.ReadLine());

            inpMetrics = Console.ReadLine();
            value = ConvToMeters();

            outpMetrics = Console.ReadLine();
            value = ConvToDest();

            Console.WriteLine(value + " " + outpMetrics);
        }
        catch (Exception)
        {
            Console.WriteLine("invalid input!");

        }





    }

    private static double ConvToMeters()
    {
        // Обръща въведената value  метри
        switch (inpMetrics)
        {
            case "mm":
                return value / 1000;
            case "cm":
                return value / 100;
            case "m":
                return value;
            case "mi":
                return value / 0.000621371192;
            case "in":
                return value / 39.3700787;
            case "km":
                return value / 0.001;
            case "ft":
                return value / 3.2808399;
            case "yd":
                return value / 1.0936133;

            default:
                throw new ApplicationException();

        }
    }
    private static double ConvToDest()
    {
        // Превръща обработената value в зададената изходна единица.
        switch (outpMetrics)
        {
            case "mm":
                return value * 1000;
            case "cm":
                return value * 100;
            case "m":
                return value;
            case "mi":
                return value * 0.000621371192;
            case "in":
                return value * 39.3700787;
            case "km":
                return value * 0.001;
            case "ft":
                return value * 3.2808399;
            case "yd":
                return value * 1.0936133;

            default:
                throw new ApplicationException();

        }
    }
}
