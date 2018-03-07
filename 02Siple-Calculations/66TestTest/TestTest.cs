using System;


class TestTest
{
    static void Main()
    {
        double numberToConvert = double.Parse(Console.ReadLine());
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        double USD = 1.79549;
        double EUR = 1.95583;
        double GBP = 2.53405;

        if (first == "BGN")
        {
            if (second == "USD")
            {
                Console.WriteLine("{0:f2},", numberToConvert / USD);
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0:f2},", numberToConvert / EUR);
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0:f2},", numberToConvert / GBP);

            }
        }
        if (first == "USD")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0:f2},", numberToConvert * USD);
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0:f2},", numberToConvert * USD/EUR);
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0:f2},", numberToConvert * USD/GBP);

            }
        }
        if (first == "EUR")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0:f2},", numberToConvert * EUR);
            }
            else if (second == "USD")
            {
                Console.WriteLine("{0:f2},", numberToConvert * EUR / USD);
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0:f2},", numberToConvert * EUR / GBP);

            }
        }
        if (first == "GBP")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0:f2},", numberToConvert * GBP);
            }
            else if (second == "USD")
            {
                Console.WriteLine("{0:f2},", numberToConvert * GBP / USD);
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0:f2},", numberToConvert * GBP / EUR);

            }
        }
    }
}

