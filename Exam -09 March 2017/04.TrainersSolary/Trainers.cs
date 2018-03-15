using System;

class Trainers
{
    static void Main()
    {
        //        •	Първи ред – колко лекции ще има – цяло число в интервала[1...100]
        //•	Втори ред – заделеният бюджет – реално число в интервала[100.00... 10000.00]
        //•	За всяка лекция – името на лектора за дадената лекция – текст съдържащ латински букви

        int countOfLekcii = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        

        double countSum = 0;
        double count1 = 0;
        double count2 = 0;
        double count3 = 0;
        double count4 = 0;
        double count5 = 0;
        double count6 = 0;


        for (int i = 0; i < countOfLekcii; i++)
        {
            string name = Console.ReadLine();
            countSum++;

            if (name == "Jelev")
            {
                count1++;
            }
            else if (name == "RoYaL")
            {
                count2++;

            }
            else if (name == "Roli")
            {
                count3++;

            }
            else if (name == "Trofon")
            {
                count4++;

            }
            else if (name == "Sino")
            {
                count5++;

            }
            else
            {
                count6++;
            }

        }

        double solary = budget / countSum;

        Console.WriteLine($"Jelev salary: {(count1*solary):f2} lv");
        Console.WriteLine($"RoYaL salary: {(count2*solary):f2} lv");
        Console.WriteLine($"Roli salary: {(count3 * solary):f2} lv");
        Console.WriteLine($"Trofon salary: {(count4 * solary):f2} lv");
        Console.WriteLine($"Sino salary: {(count5 * solary):f2} lv");
        Console.WriteLine($"Others salary: {(count6 * solary):f2} lv");



    }
}

