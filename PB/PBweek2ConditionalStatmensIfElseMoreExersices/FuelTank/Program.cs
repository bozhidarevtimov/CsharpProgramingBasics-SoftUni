﻿using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която познава дали резервоара на едно превозно средство има нужда от
            // презареждане на горивото или не.От конзолата се четат два реда – текст и реално число,
            // на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas",
            // а на втория литрите гориво, които има в резервоара. Ако литрите гориво са повече или равни на 25,
            // на конзолата да се отпечата "You have enough {вида на горивото}.", ако са по - малко от 25,
            // да се отпечата "Fill your tank with {вида на горивото}!".
            // В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".


            //От конзолата се четат два реда – текст и реално число,
            // на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas",
            // а на втория литрите гориво, които има в резервоара.
            string fuelType = Console.ReadLine();
            double fuelInCar = double.Parse(Console.ReadLine());

            string diesel = "Diesel";
            string gas = "Gas";
            string gasoline = "Gasoline";


            //Ако литрите гориво са повече или равни на 25,
            // на конзолата да се отпечата "You have enough {вида на горивото}.",
            bool a = fuelType.Equals(diesel);
            bool b = fuelType.Equals(gas);
            bool c = fuelType.Equals(gasoline);
            if (fuelInCar>=25)
            {
                if (a==true)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else if (b==true)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else if (c==true)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Invalid fuel!");
                }

            }
            //aко са по - малко от 25,
            // да се отпечата "Fill your tank with {вида на горивото}!".
            else if (fuelInCar<25)
            {
                if (a == true)
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
                else if (b == true)
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
                else if (c == true)
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
                else
                {
                    Console.WriteLine($"Invalid fuel!");
                }
            }
            //В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".



        }
    }
}
