using System;

class Numbers
{
    static void Main()
    {
        double n1 = int.Parse(Console.ReadLine());
        double n2 = int.Parse(Console.ReadLine());
        char opperator = char.Parse(Console.ReadLine());

        double result = 0;
        string evenOdds = string.Empty;

        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
            return;
        }

        if (opperator == '+')
        {
            result = n1 + n2;
            if (result % 2 == 0)
            {
                evenOdds = "even";
            }
            else
            {
                evenOdds = "odd";
            }
            Console.WriteLine($"{n1} + {n2} = {result} - {evenOdds}");
        }

        else if(opperator == '-')
        {
            result = n1 - n2;
            if (result % 2 == 0)
            {
                evenOdds = "even";
            }
            else
            {
                evenOdds = "odd";
            }
            Console.WriteLine($"{n1} - {n2} = {result} - {evenOdds}");
        }

        else if (opperator == '*')
        {
            result = n1 * n2;
            if (result % 2 == 0)
            {
                evenOdds = "even";
            }
            else
            {
                evenOdds = "odd";
            }
            Console.WriteLine($"{n1} * {n2} = {result} - {evenOdds}");
        }

        else if (opperator == '/')
        {
            result = n1 / n2;
            
            Console.WriteLine($"{n1} / {n2} = {result:f2}");
        }
        else if (opperator == '%')
        {
            result = n1 % n2;

            Console.WriteLine($"{n1} % {n2} = {result}");
        }


    }
}

