using System;

class Cinema
{
    static void Main()
    {
        string project = Console.ReadLine();
        int redove = int.Parse(Console.ReadLine());
        int koloni = int.Parse(Console.ReadLine());

        double premiere = 0;
        double normal = 0;
        double discount = 0;


        if (project == "Premiere")
        {
            premiere = redove * koloni * 12.00;
            Console.WriteLine($"{premiere:f2} leva");
        }
        else if (project == "Normal")
        {
            normal = redove * koloni * 7.50;
            Console.WriteLine($"{normal:f2} leva");
        }
        else if (project == "Discount")
        {
            discount = redove * koloni * 5.00;
            Console.WriteLine($"{discount:f2}");

        }

    }
}

