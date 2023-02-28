using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Магазин за плодове през работните дни работи на следните цени:
            // плод   banana  apple    orange grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45       2.70     5.50     3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //плод banana  apple orange  grapefruit kiwi pineapple grapes
            //цена  2.70    1.25   0.90    1.60    3.00    5.60    4.20
            //Напишете програма, която чете от конзолата плод
            //(banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            //ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday)
            //и количество(реално число) , въведени от потребителя, и пресмята цената според цените от таблиците по-горе.
            //Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
            //При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qnty = double.Parse(Console.ReadLine());
            double price = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                // плод   banana  apple    orange grapefruit kiwi    pineapple grapes
                //цена    2.50    1.20    0.85    1.45       2.70     5.50     3.85
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                if (price != 0)
                {
                    Console.WriteLine($"{qnty * price:f2}");
                }

            }
            //Събота и неделя магазинът работи на по - високи цени:
            //плод banana  apple orange  grapefruit kiwi pineapple grapes
            //цена  2.70    1.25   0.90    1.60    3.00    5.60    4.20
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                if (price != 0)
                {
                    Console.WriteLine($"{qnty * price:f2}");
                }

            }
            else 
            {
                        Console.WriteLine("error");
            }

        

    }
    }
}
