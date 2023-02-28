using System;

namespace SkipTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Атанас решава да прекара отпуската си в Банско и да кара ски.
            //Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя.
            //Налични са следните видове помещения, със следните цени за престой:
            //	"room for one person" – 18.00 лв за нощувка
            //	"apartment" – 25.00 лв за нощувка
            //	"president apartment" – 35.00 лв за нощувка
            //Според броят на дните, в които ще остане в хотела(пример: 11 дни = 10 нощувки)
            //и видът на помещението, което ще избере, той може да ползва различно намаление.
            //Намаленията са както следва:


            //вид помещение             по - малко от 10 дни          между 10 и 15 дни            повече от 15 дни
            //room for one person        не ползва намаление         не ползва намаление          не ползва намаление
            //apartment                  30 % от крайната цена       35 % от крайната цена       50 % от крайната цена
            //president apartment       10 % от крайната цена        15 % от крайната цена       20 % от крайната цена

            //След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive)
            //или негативна(negative) . Ако оценката му е позитивна, към цената с вече приспаднатото намаление
            //Атанас добавя 25 % от нея.Ако оценката му е негативна приспада от цената 10 %.

            //            Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            //•	Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            //•	Трети ред -оценка - "positive"  или "negative"
            int days = int.Parse(Console.ReadLine());
            string typeOfAcom = Console.ReadLine();
            string grade = Console.ReadLine();
            //цени за стай без намаление(дните по цената за нощувка - 1път цената (пример: 11 дни = 10 нощувки))
            double RoomPrice = (days * 18.00) - 18.00;
            double apartPrice = (days * 25.00) - 25.00;
            double persiApartPrice = (days * 35.00) - 35.00;
            double totallPrice = 0.00;

            //проверка за дните и прилагане на отстъпките   
            if (days < 10)
            {
                switch (typeOfAcom)
                {
                    case "room for one person":
                        totallPrice = RoomPrice;
                        break;
                    case "apartment":
                        totallPrice = apartPrice;
                        totallPrice -= apartPrice * 0.30;
                        break;
                    case "president apartment":
                        totallPrice = persiApartPrice;
                        totallPrice -= persiApartPrice * 0.10;
                        break;
                }
            }
            else if (days < 16)
            {
                switch (typeOfAcom)
                {
                    case "room for one person":
                        totallPrice = RoomPrice;
                        break;
                    case "apartment":
                        totallPrice = apartPrice;
                        totallPrice -= apartPrice * 0.35;
                        break;
                    case "president apartment":
                        totallPrice = persiApartPrice;
                        totallPrice -= persiApartPrice * 0.15;
                        break;
                }
            }
            else
            {
                switch (typeOfAcom)
                {
                    case "room for one person":
                        totallPrice = RoomPrice;
                        break;
                    case "apartment":
                        totallPrice = apartPrice;
                        totallPrice -= apartPrice * 0.50;
                        break;
                    case "president apartment":
                        totallPrice = persiApartPrice;
                        totallPrice -= persiApartPrice * 0.20;
                        break;
                }
            }

            //проверка за оценката и съответното намаление или увеличаване на цената
            if (grade == "positive")
            {
                totallPrice += totallPrice * 0.25;
            }
            else 
            {
                totallPrice -= totallPrice * 0.10;
            }


            Console.WriteLine($"{totallPrice:f2}");

            //            На конзолата трябва да се отпечата един ред:
            //•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.


        }
    }
}
