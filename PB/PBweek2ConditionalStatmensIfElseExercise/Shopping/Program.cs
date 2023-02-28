using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Петър иска да купи N видеокарти, M процесора и P на брой рам памет.
            //Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка.
            //Важат следните цени:
            //•	Видеокарта – 250 лв./ бр.
            //•	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //•	Рам памет – 10 % от цената на закупените видеокарти/ бр.
            //Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.

            // Вход
            //Входът се състои от четири реда:
            //1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            double budjet = double.Parse(Console.ReadLine());
            //2.Броят видеокарти - цяло число в интервала[0…100]
            double videoCards = double.Parse(Console.ReadLine());
            //3.Броят процесори - цяло число в интервала[0…100]
            double processors = double.Parse(Console.ReadLine());
            //4.Броят рам памет -цяло число в интервала[0…100]
            double ram = double.Parse(Console.ReadLine());

            //CЦена на виео карти
            double videoCardsPrice = videoCards * 250;
            //цена процесори
            double processorsPrice = (videoCardsPrice * 0.35)*processors;
            //цена рam
            double ramPrice = (videoCardsPrice * 0.10) * ram;

            //обща цена
            double totall = videoCardsPrice + processorsPrice + ramPrice;
            //Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка.
            if (videoCards>processors)
            {
                totall -= totall * 0.15;
            }
            //обща цена


            //Изход Резултатът да се форматира до втория знак след десетичната запетая.
            //На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
            //•	Ако бюджета е достатъчен:
            //"You have {остатъчен бюджет} leva left!"
            if (budjet>=totall)
            {
                Console.WriteLine($"You have {budjet - totall:f2} leva left!");
            }
            //•	Ако сумата надхвърля бюджета:
            //"Not enough money! You need {нужна сума} leva more!"
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budjet-totall):f2} leva more!");
            }
            //Резултатът да се форматира до втория знак след десетичната запетая.


        }
    }
}
