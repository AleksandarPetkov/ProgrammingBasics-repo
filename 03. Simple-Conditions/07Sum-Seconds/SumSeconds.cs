using System;

class SumSeconds
{
    static void Main()
    {
        int time1 = int.Parse(Console.ReadLine());
        int time2 = int.Parse(Console.ReadLine());
        int time3 = int.Parse(Console.ReadLine());

        int sumTimes = time1 + time2 + time3;   

        int min = sumTimes / 60;        //Мин. получавам като разделя на 60
        int seconds = sumTimes % 60;    // Сек. се получават с остатъчно деление от 60/Пример 90%60 остатъка е 30 !

        if (seconds < 10)
        {
            Console.WriteLine($"{min}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{min}:{seconds}");   
        }





    }
}
