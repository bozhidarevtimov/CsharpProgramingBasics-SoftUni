using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени
            //според града:

      //град/продукт coffee  water    beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            //Напишете програма, която чете продукт(низ), град(низ) и количество(десетично число),
            //въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от
            //избрания продукт в посочения град. 

            //чете продукт(низ), град(низ) и количество(десетично число)
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qnty = double.Parse(Console.ReadLine());
            double price = 0;
            if (city == "Sofia") 
            {
                switch (product) 
                {
                    case "coffee":
                        price = 0.50;
                        break;
                    case "water":
                        price = 0.80;
                        break;
                    case "beer":
                        price = 1.20;
                        break;
                    case "sweets":
                        price = 1.45;
                        break;
                    case "peanuts":
                        price = 1.60;
                        break;
                }

            }
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.40;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "beer":
                        price = 1.15;
                        break;
                    case "sweets":
                        price = 1.30;
                        break;
                    case "peanuts":
                        price = 1.50;
                        break;
                }
            }
            //Varna   0.45    0.70    1.10    1.35    1.55
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.45;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "beer":
                        price = 1.10;
                        break;
                    case "sweets":
                        price = 1.35;
                        break;
                    case "peanuts":
                        price = 1.55;
                        break;
                }
            }
            Console.WriteLine($"{qnty * price}");

        }
    }
}
