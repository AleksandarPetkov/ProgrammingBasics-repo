using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Два начина на решаване:
            // 1: Започвам от 7 и увеличавам с 10 докато стигна < 1000
            // 2: С проверка: Проверям с процентно деление дали делителя е 7




            //for (int num = 7; num < 1000; num += 10)   
            //{
            //    Console.WriteLine(num);
            //}

            for (int num= 0; num < 1000; num++)
            {
                if (num % 10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }



       
    }


}
