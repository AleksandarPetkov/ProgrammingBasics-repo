using System;

class Camp
{
    static void Main()
    {
        int groups = int.Parse(Console.ReadLine());

        double firstGroup = 0;
        double secondGroup = 0;
        double thirtGroup = 0;
        double fourthGroup = 0;
        double fifthGroup = 0;

        double sumAllStudents = 0;

        for (int i = 0; i < groups; i++)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            sumAllStudents +=countOfStudents;

            if (countOfStudents <= 5)
            {
                firstGroup = firstGroup + countOfStudents;

            }
            else if (countOfStudents > 5 && countOfStudents <=12)
            {
                secondGroup += countOfStudents;
            }
            else if (countOfStudents > 12 && countOfStudents <= 25)
            {
                thirtGroup += countOfStudents;
            }
            else if (countOfStudents > 25 && countOfStudents <= 40)
            {
                fourthGroup += countOfStudents;
            }
            else if (countOfStudents > 40)
            {
                fifthGroup += countOfStudents;
            }
        }

        double procentFirstGroup = (firstGroup / sumAllStudents) * 100;
        double procentSecondGroup = (secondGroup / sumAllStudents) * 100;
        double procentThirtGroup = (thirtGroup / sumAllStudents) * 100;
        double procentFourthGroup = (fourthGroup / sumAllStudents) * 100;
        double procentFifthGroup = (fifthGroup/ sumAllStudents) * 100;

        Console.WriteLine($"{procentFirstGroup:f2}%");
        Console.WriteLine($"{procentSecondGroup:f2}%");
        Console.WriteLine($"{procentThirtGroup:f2}%");
        Console.WriteLine($"{procentFourthGroup:f2}%");
        Console.WriteLine($"{procentFifthGroup:f2}%");


    }
}

