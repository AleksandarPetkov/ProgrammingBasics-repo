﻿using System;

class VowelsSum
{
    static void Main()
    {
        string text = Console.ReadLine();

        int sum = 0; 

        for (int i = 0; i <= text.Length - 1 ; i++)
        {
            char symbol = text[i] ;

            if (symbol == 'a')
            {
                sum += 1;
            }
            else if (symbol == 'e')
            {
                sum += 2;
            }
            else if (symbol == 'i')
            {
                sum += 3;
            }
            else if (symbol == 'o')
            {
                sum += 4;
            }
            else if (symbol == 'u')
            {
                sum += 5;
            }

        }

        Console.WriteLine(sum);
    }
}

