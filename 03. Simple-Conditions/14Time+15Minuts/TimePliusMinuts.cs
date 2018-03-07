using System;

class TimePliusMinuts
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minuts = int.Parse(Console.ReadLine());
                                                          //ХУБАВО ДА СЕ РАЗГЛЕЖДА УСЛОВИЕТО !!!
        minuts = minuts + 15;

        if (minuts > 59)             // Декларирам  ВСИЧКИ възможни проверки,
        {                            // преди да изведа резултата !!!
            hour++;
            minuts -= 60;
        }
        if (hour >=24)
        {
            hour = 0;
        }
        if (minuts < 10)
        {
            Console.WriteLine($"{hour}:0{minuts}");
        }
        else
        {
            Console.WriteLine($"{hour}:{minuts}");
        }
        
                
                       
    }
}

