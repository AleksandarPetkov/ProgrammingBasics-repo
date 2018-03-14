using System;

class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //1 Start
        int middleDashes = (n*2) - 1;
        int leftRightStars = 1;

        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}",new string('*',leftRightStars),new string('-',middleDashes));
            leftRightStars++;
            middleDashes -= 2;
        }
        //1 End

        //2 Start
        int row = (n/ 3);
        int middleLeftStars = n / 2;
        int middleStars = n;

        for (int i = 1; i <= row; i++)
        {
            Console.WriteLine(@"|{0}\{1}/{0}|",new string('*',middleLeftStars),new string('*',middleStars));

            middleLeftStars++;
            middleStars -= 2;
        }
        //End 2

        //Start 3
        int down = 1;
        int downMidd = (2 * n) - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('-', down), new string('*', downMidd));
            down++;
            downMidd -= 2;
        }


    }
}

