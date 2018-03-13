using System;

class SmartLili
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double priceWashMashine = double.Parse(Console.ReadLine());
        int priceOfToy = int.Parse(Console.ReadLine());

        double collectMoney = 0;
        double countOfToys = 0;
        double steal = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 1)
            {
                countOfToys++;
            }
            else if (i % 2 == 0)
            {
                steal++;
                collectMoney = collectMoney + (10 * i) / 2;
            }

        }
        double totalPriceToys = (priceOfToy * countOfToys);

        double totalCollect = (totalPriceToys + collectMoney) - steal;

        if (priceWashMashine <= totalCollect)
        {
            double diff = Math.Abs(totalCollect - priceWashMashine);

            Console.WriteLine($"Yes! {diff:f2}");
        }
        else
        {
            double diff = Math.Abs(totalCollect - priceWashMashine);
            Console.WriteLine($"No! {diff:f2}");
        }
    }
}

