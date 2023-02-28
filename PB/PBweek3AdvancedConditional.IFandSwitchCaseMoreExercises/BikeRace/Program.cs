using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предстои Вело състезание за благотворителност в което участниците са разпределени в младша("juniors")
            //и старша("seniors") група.Парите се набавят от таксата за участие на велосипедистите.
            //Според възрастовата група и вида на трасето на което ще се провежда състезанието, таксата е различна.

            //Група           trail   cross - country   downhill     road
            //juniors          5.50         8             12.25       20
            //seniors           7          9.50          13.75       21.50

            //Ako в "cross-country" състезанието се съберат 50 или повече участника(общо младши и старши),
            //таксата намалява с 25 %.
            //Организаторите отделят 5 % процента от събраната сума за разходи.
            //Вход
            //От конзолата се четат 2 числа и един стринг, всяко на отделен ред:
            //•	Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            //•	Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            //•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"
            //Изход
            //Да се отпечата на конзолата едно число:
            //"{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.

            //1. Четем от конзолата
            //броят младши вело
            int junors = int.Parse(Console.ReadLine());
            //броят старши вело
            int seniors = int.Parse(Console.ReadLine());
            //тип на трасе
            string typeRace = Console.ReadLine();

            //променливи
            //цена на такса за младши
            double juniorPrice = 0;
            //цена на такса за старши
            double seniorPrice = 0;

            //2. Проверяваме какво е трацето и присвояваме съответната цена на таксата за младши и старши
            switch (typeRace) 
            {
                case "trail":
                    juniorPrice = 5.50;
                    seniorPrice = 7;
                        break;
                case "cross-country":
                    juniorPrice = 8;
                    seniorPrice = 9.50;
                    break;
                case "downhill":
                    juniorPrice = 12.25;
                    seniorPrice = 13.75;
                    break;
                case "road":
                    juniorPrice = 20;
                    seniorPrice = 21.50;
                    break;
            }

            //3. проверяваме дали общо състезатилете в крос-кънтри са повече от 50 и намаляваме 25%от всяка такса
            if (typeRace== "cross-country" && junors + seniors >= 50)
            {
                juniorPrice -=juniorPrice*0.25;
                seniorPrice -= seniorPrice * 0.25;
            }
            //4. калкулираме общо събраната такса т младши и старши като умножим цената за младши по броят младши и цената за старши по броят старши
            //изваждаме 5% от всичко, които отиват за разходи и получаваме сумата за даряване
            double charityMoney = (double)junors * juniorPrice + (double)seniors * seniorPrice;
            charityMoney -= charityMoney * 0.05;
            //Да се отпечата на конзолата едно число:
            //"{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.
            Console.WriteLine($"{charityMoney:f2}");


        }
    }
}
