using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Хотел предлага 2 вида стаи: студио и апартамент.Напишете програма,
            //която изчислява цената за целия престой за студио и апартамент.
            //Цените зависят от месеца на престоя:

            //Май и октомври              Юни и септември                       Юли и август
            //Студио – 50 лв./ нощувка       Студио – 75.20 лв./ нощувка          Студио – 76 лв./ нощувка
            //Апартамент – 65 лв./нощувка    Апартамент – 68.70 лв./ нощувка      Апартамент – 77 лв./ нощувка

            //            Предлагат се и следните отстъпки:
            //•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            //            Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
            //•	На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            //правим си променливи za цените на апартамент или студио
            //и за обща цена
            //проверяваме кой месец е и слагаме цена за Студио и апартамент
            //и проверяваме колко са нощувките за да определим дали има намаление
            double studioPrice = 0.00;
            double AptPrice = 0.00;
            double totallStudio = 0.00;
            double totallApt = 0.00;

            switch (month)
            {

                case "May":
                case "October":
                    studioPrice = 50.00;
                    AptPrice = 65.00;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    AptPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    AptPrice = 77.00;
                    break;


                default:
                    break;
            }



            if (month == "May" || month == "October") 
            {

                if (nights > 7 && nights<14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (nights > 14) 
                {
                    studioPrice -= studioPrice * 0.30;
                    AptPrice -= AptPrice * 0.10;
                }
                totallStudio = nights * studioPrice;
                totallApt = nights * AptPrice;
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    AptPrice -= AptPrice * 0.10;
                }
                totallStudio = nights * studioPrice;
                totallApt = nights * AptPrice;
            }
            else
            {
                if (nights > 14)
                {
                    AptPrice -= AptPrice * 0.10;
                }
                totallStudio = nights * studioPrice;
                totallApt = nights * AptPrice;
            }
            Console.WriteLine($"Apartment: {totallApt:f2} lv.");
            Console.WriteLine($"Studio: {totallStudio:f2} lv.");
            //            Да се отпечатат на конзолата 2 реда:
            //•	На първия ред: “Apartment: { цена за целият престой}
            //            lv.”
            //•	На втория ред: “Studio: { цена за целият престой}
            //            lv.“
            //Цената за целия престой форматирана с точност до два знака след десетичната запетая.



        }
    }
}
