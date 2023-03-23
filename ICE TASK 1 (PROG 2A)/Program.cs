using System;

namespace EggFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs do you want to order?");
            int amountOfEggs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You have ordered: " + amountOfEggs + " eggs" );

            int dozen = amountOfEggs / 12;
            int looseEgg = amountOfEggs % 12;

            double dozenPrice = Convert.ToDouble(dozen);
            double looseEggPrice = Convert.ToDouble(looseEgg);

            double price = (dozenPrice * 3.25) + (looseEggPrice * 0.45);


            Console.WriteLine("That is " + dozen + " dozen at $3.25 per Dozen.");
            Console.WriteLine("You have " + looseEgg + " loose eggs at $0.45 per egg.");
            Console.WriteLine("The total amount due for all the " + amountOfEggs + " egg(s) is: $" + price);

            // 


        }
    }
}