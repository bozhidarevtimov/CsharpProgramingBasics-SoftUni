using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да изчислява, колко ще струва на един шофьор да напълни резервоара
            //на автомобила си, като знаете – какъв тип гориво зарежда, каква е цената за литър гориво и
            //дали разполага с карта за отстъпки. Цените на горивата са както следва: 
            //•	Бензин – 2.22 лева за един литър,
            //•	Дизел – 2.33 лева за един литър
            //•	Газ – 0.93 лева за литър
            //Ако водача има карта за отстъпки,  той се възползва от следните намаления за литър гориво:
            //18 ст.за литър бензин, 12 ст.за литър дизел и 8 ст.за литър газ.
            //Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена,
            //при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.

            //Вход
         //          Входът се чете от конзолата и се състои от 3 реда:
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            string fuelType = Console.ReadLine(); // "Diesel", "Gasoline", "Gas"
            //•	Количество гориво – реално число в интервала[1.00 … 50.00]
            double litersFuel = double.Parse(Console.ReadLine());
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"
            string clubCard = Console.ReadLine(); // "Yes", "No"


            //Създаваме bool за да го изпозваме при проверка на картата
            bool chekCard = true;
            //Проверка за картата и ако е няма картата настройваме bool checkCard to False и обратното
            if (clubCard == "No")
            {
                chekCard = false;
            }
            else if (clubCard == "Yes")
            {
                chekCard = true;
            }


            //Добавамя променливи за цените и намаленията с карта за всяко гориво
            double diesel = 2.33;
            double dieselDiscount = 0.12;
            double gasoline = 2.22;
            double gasolineDiscount = 0.18;
            double gas = 0.93;
            double gasDiscount = 0.08;

            // проверяваме дали има карта(if bool chekCard is true)
            // и ако е, изваждаме намалението за литър от цената на горивото
            if (chekCard)
            {
                diesel -= dieselDiscount;
                gasoline -= gasolineDiscount;
                gas -= gasDiscount;
            }
            //Създаваме променливи за крайна цена, отстъпки при 20до25 и над 20 литра
            double fuelPrice = 0.0;
            double discount20 = 0.08;
            double discount25 = 0.10;
            //Създаваме switch case структура за проверка на типа гориво и пресмятаме цената за зареденото количество
            // като в if по горе вече сме извадили отстъпката от цената за литър, ако имат карта за отстъпка
            switch (fuelType)
            {
                case "Diesel":
                    fuelPrice = diesel * litersFuel;
                    break;
                case "Gasoline":
                    fuelPrice = gasoline * litersFuel;
                    break;
                case "Gas":
                    fuelPrice = gas * litersFuel;
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
            // Проверяваме дали зареденото количество е между20 и 25 ии повече и изваждаме отстъпката от крайната цена
            // като по горе сме си направили променливите със стойноста на отстъпките. И принтираме резултата.
            if (litersFuel >= 20 && litersFuel <= 25)
            {
                fuelPrice = fuelPrice - (fuelPrice * discount20);
            }
            else if (litersFuel > 25)
            {
                fuelPrice = fuelPrice - (fuelPrice * discount25);
            }
            Console.WriteLine($"{fuelPrice:f2} lv.");
        }
    }

    //Изход
    //       На конзолата трябва да се отпечата един ред.
    //•	"{крайната цена на горивото} lv."
    //Цената на горивото да бъде форматираната до втората цифра след десетичния знак.
}
