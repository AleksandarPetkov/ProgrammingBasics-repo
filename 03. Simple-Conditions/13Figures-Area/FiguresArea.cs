using System;

class FiguresArea
{
    static void Main()
    {
        string figures = Console.ReadLine();
        double variable1 = double.Parse(Console.ReadLine());
        


        if (figures == "square") 
        {
            Console.WriteLine(variable1 * variable1);
        }
        else if (figures == "rectangle")
        {
            double variable2 = double.Parse(Console.ReadLine());
            Console.WriteLine(variable1 * variable2);
        }
        else if (figures == "circle")
        {
            Console.WriteLine(Math.PI * variable1 * variable1) ;
        }
        else if (figures == "triangle")
        {
            double variable2 = double.Parse(Console.ReadLine());
            Console.WriteLine((variable1 * variable2) / 2);
        }

    }
}

