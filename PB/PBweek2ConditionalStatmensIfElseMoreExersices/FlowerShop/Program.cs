using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Мария иска да купи подарък на сина си. Тя работи в магазин за цветя.
            //В магазина идва поръчка за цветя. Напишете програма, която пресмята сумата
            //от поръчката и дали печалбата е достатъчна за подаръка. Цветята имат следните цени:

            //•	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5 % данъци.

            //            / Вход
            //Входът се чете от конзолата и се състои от 5 реда:
            //•	Брой магнолии – цяло число в интервала[0 … 50]
            double magnolii = double.Parse(Console.ReadLine());
            //•	Брой зюмбюли – цяло число в интервала[0 … 50]
            double zumbuli = double.Parse(Console.ReadLine());
            //•	Брой рози – цяло число в интервала[0 … 50]
            double roses = double.Parse(Console.ReadLine());
            //•	Брой кактуси – цяло число в интервала[0 … 50]
            double kaktus = double.Parse(Console.ReadLine());
            //•	Цена на подаръка – реално число в интервала[0.00 … 500.00]
            double giftPrice = double.Parse(Console.ReadLine());

            //цената на поръчката
            double totall = magnolii * 3.25 + zumbuli * 4.00 + roses * 3.50 + kaktus * 8.00;
            // изваждаме 5%
            totall -= totall * 0.05;


            //          Изход
            //На конзолата трябва да се отпечата един ред.
            //•	Ако парите СА стигнали: "She is left with {останали} leva."
            //– сумата трябва да е закръглена към по - малко цяло число(пр. 1.90-> 1).
            if (totall>=giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totall - giftPrice)} leva.");
            }
            //•	Ако парите НЕ достигат: "She will have to borrow {останали} leva."
            //– сумата трябва да е закръглена към по - голямо цяло число(пр. 1.10-> 2).
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-totall)} leva.");
            }


        }
    }
}
