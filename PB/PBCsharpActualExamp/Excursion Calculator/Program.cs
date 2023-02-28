using System;

namespace Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Туристическа агенция предлага екскурзии на различни цени, според сезона и броя на хората.

            //Напишете програма, която да изчислява цената, според данните от таблицата:
            //                Пролет(spring)       Лято(summer)         Есен(autumn)          Зима(winter)
            //До 5 човека     50.00 лв.на човек    48.50 лв.на човек    60.00 лв.на човек     86.00 лв.на човек
            //Над 5 човека    48.00 лв.на човек    45.00 лв.на човек    49.50 лв.на човек     85.00 лв.на човек


            //В зависимост от сезона, може да има отстъпка или оскъпяване на цената, съответно:
            //•	При "summer"-> 15 % отстъпка
            //•	При "winter"-> 8 % оскъпяване

            //Вход:
            //1.Първи ред – брой хора – цяло число в интервала[1 … 20]
            //2.Втори ред – сезон – текст с възможности - "spring", "summer", "autumn" или "winter"
            //Изход:
            //            На конзолата се отпечатва 1 ред:
            // •   Цената за екскурзията, форматирана до втория знак след десетичния разделител, в следния формат: "{цената} leva."


            //1.Четем 
            //.Първи ред – брой хора – цяло число в интервала[1 … 20]
            int people = int.Parse(Console.ReadLine());
            //.Втори ред – сезон – текст с възможности - "spring", "summer", "autumn" или "winter"
            string season = Console.ReadLine();

            //променливи
            double price = 0;

            double discount15 = 0.15;
            double priceUp8 = 0.08;


            //2. проверки
            //Напишете програма, която да изчислява цената, според данните от таблицата:
            //                Пролет(spring)       Лято(summer)         Есен(autumn)          Зима(winter)
            //До 5 човека     50.00 лв.на човек    48.50 лв.на човек    60.00 лв.на човек     86.00 лв.на човек
            //Над 5 човека    48.00 лв.на човек    45.00 лв.на човек    49.50 лв.на човек     85.00 лв.на човек



            if (people <= 5)
            {
                switch (season)
                {                     //Пролет(spring)       Лято(summer)         Есен(autumn)          Зима(winter)
                    //До 5 човека     50.00 лв.на човек    48.50 лв.на човек    60.00 лв.на човек     86.00 лв.на човек
                    case "spring":
                        price = people * 50.00;
                        break;
                    case "summer":
                        price = people * 48.50;
                        break;
                    case "autumn":
                        price = people * 60.00;
                        break;
                    case "winter":
                        price = people * 86.00;
                        break;
                }
            }
            else 
            {
                switch (season)
                {
                    //Пролет(spring)       Лято(summer)         Есен(autumn)          Зима(winter)
                   
                    //48.00 лв.на човек    45.00 лв.на човек    49.50 лв.на човек     85.00 лв.на човек
                    
                    case "spring":
                        price = people * 48.00;
                        break;
                    case "summer":
                        price = people * 45.00;
                        break;
                    case "autumn":
                        price = people * 49.50;
                        break;
                    case "winter":
                        price = people * 85.00;
                        break;
                }
            }
            //В зависимост от сезона, може да има отстъпка или оскъпяване на цената, съответно:
            //•	При "summer"-> 15 % отстъпка
            //•	При "winter"-> 8 % оскъпяване
            //отстъпката и увеличението е на крайната цена

            //На конзолата се отпечатва 1 ред:
            // Цената за екскурзията, форматирана до втория знак след десетичния разделител, в следния формат: "{цената} leva."
            if (season== "summer")
            {
                price -= price * discount15;
                Console.WriteLine($"{price:f2} leva.");
            }
            else if (season == "winter")
            {
                price += price * priceUp8;
                Console.WriteLine($"{price:f2} leva.");
            }
            else
            {
                Console.WriteLine($"{price:f2} leva.");
            }


        }
    }
}
