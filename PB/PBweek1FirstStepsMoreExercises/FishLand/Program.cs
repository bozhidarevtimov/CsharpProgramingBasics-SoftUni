using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди.
            // Затова отива на рибната борса, за да си купи по няколко килограма.
            // Oт конзолата се въвеждат цените в лева на скумрията и цацата.
            // Също количеството на паламуд, сафрид и миди в килограми.
            // Колко пари ще са му необходими, за да плати сметката си, ако цените на борсата са:

            //•	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм


            //Вход
            //От конзолата се четат 5 числа:
            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            double skumriPrice = double.Parse(Console.ReadLine());
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            double cacaPrice = double.Parse(Console.ReadLine());
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            double palamudKg = double.Parse(Console.ReadLine());
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            double safridKg = double.Parse(Console.ReadLine());
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            double midiKg = double.Parse(Console.ReadLine());


            //Calculation of the price for the uknown prices
            //•	Паламуд – 60 % по - скъп от скумрията
            double palamudPrice = skumriPrice + skumriPrice * 0.60;
            //•	Сафрид – 80 % по - скъп от цацата
            double safridPrice = cacaPrice + cacaPrice * 0.80;
            //•	Миди – 7.50 лв.за килограм
            double midiPrice = 7.50;


            // Изход
            //Да се отпечата на конзолата едно число с плаваща запетая:
            //колко пари ще са нужни на Георги, за да си плати сметката.
            //Числото трябва да е форматирано до вторият знак след десетичната запетая(1.2457-> 1.25).
            double totall = palamudKg * palamudPrice + safridKg * safridPrice + midiKg * midiPrice;
            Console.WriteLine(totall.ToString("0.00"));


        }
    }
}
