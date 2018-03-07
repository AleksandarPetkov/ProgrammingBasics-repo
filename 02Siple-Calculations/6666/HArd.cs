using System;
using System.Globalization;

class HArd
{
    static void Main()
    {
        string date = Console.ReadLine();
        DateTime birthday;
        birthday = DateTime.ParseExact(date,"dd-MM-yyyy", CultureInfo.InvariantCulture);
        birthday = birthday.AddDays(999);

        Console.WriteLine(birthday.ToString("dd-MM-yyyy"));
    }
}

