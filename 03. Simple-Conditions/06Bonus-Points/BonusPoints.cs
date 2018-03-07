using System;

class BonusPoints
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        // Декларирам две променливи за бонусите
        double bonus = 0;
        double addbonus = 0;


        // Първо  смятам за първият бонус
        // Гледам ХУБАВО! условието и извършвам нужните пресмятания

        if (num <= 100)
        {
            bonus = bonus + 5;
        }
        else if (num <= 1000)
        {
            bonus = num * 0.2;
        }
        else if (num > 1000)
        {
            bonus = num * 0.1;
        }
        //После допълнителнителният
        if (num % 2 == 0)
        {
            addbonus = addbonus + 1;
        }
        else if (num % 10 == 5)
        {
            addbonus = addbonus + 2;
        }
        Console.WriteLine(bonus + addbonus);
        Console.WriteLine(num + bonus + addbonus);

    }
}

