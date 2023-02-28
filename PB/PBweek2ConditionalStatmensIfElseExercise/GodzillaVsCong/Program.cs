using System;

namespace GodzillaVsCong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Снимките за дългоочаквания филм "Годзила срещу Конг" започват. Сценаристът Адам Уингард ви моли да 
            //напишете програма, която да изчисли, дали предвидените средства са достатъчни за снимането на филма.
            //За снимките  ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.



            //Вход
            //От конзолата се четат 3 реда:
            //          Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            double budjet = double.Parse(Console.ReadLine());
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            int statisti = int.Parse(Console.ReadLine());
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double priceClothesFor1 = double.Parse(Console.ReadLine());

            //За снимките  ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
            //Известно е, че:
            //•	Декорът за филма е на стойност 10 % от бюджета.
            double decorPrice = budjet * 0.10;
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            double clothesPrice = statisti * priceClothesFor1;
            if (statisti>150)
            {
                clothesPrice -= clothesPrice * 0.10;
            }
            double totall = decorPrice + clothesPrice;
            // Изход //Резултатът трябва да е форматиран до втория знак след десетичната запетая.
            //На конзолата трябва да се отпечатат два реда:
            if (budjet>=totall)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budjet-totall:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totall-budjet:f2} leva more.");
            }
            //•	Ако парите за декора и дрехите са повече от бюджета:
            //o   "Not enough money!"
            //o   "Wingard needs {парите недостигащи за филма} leva more."
            //•	Ако парите за декора и дрехите са по малко или равни на бюджета:
            //            o   "Action!"
            //o   "Wingard starts filming with {останалите пари} leva left."




        }
    }
}
