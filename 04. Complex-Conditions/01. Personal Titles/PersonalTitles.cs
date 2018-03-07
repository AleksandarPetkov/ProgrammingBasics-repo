using System;

class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine();

        if (sex == "m")
        {
            if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else 
            {
                Console.WriteLine("Master");
            }
        }

        if (sex == "f")
        {
            if (age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }

        }


    }
}

