using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята,
            //че Ви убеждава да напишете програма която да изчисли колко  ще им струва,
            //да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен.
            //Различните цветя са с различни цени. 

            // цвете              Роза    Далия    Лале    Нарцис   Гладиола
            //Цена на брой в лева   5       3.80    2.80      3       2.50

            //            Съществуват следните отстъпки:
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена

            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            //От конзолата се четат 3 реда:
            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]
            string flower = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //създаваме си променлива за цена на едно цвете и за общата цена
            double totall = 0.00;
            double rosePrice = qty * 5.00;
            double dahliasPrice = qty * 3.80;
            double tulipsPrice = qty * 2.80;
            double narcisPrice = qty * 3.00;
            double gladiPrice = qty * 2.50;


            //даваме цена за всяко цвете и проверяваме количеството при всеки един вид цветя за да
            //калкулираме отстъпките или увеличението в цената
            switch (flower) 
            {
                case "Roses":
                    totall = rosePrice;
                    if (qty>=80) 
                    {
                        totall -= totall * 0.10;
                    }
                    break;

                case "Dahlias":
                    totall = dahliasPrice;
                    if (qty >= 90)
                    {
                        totall -= totall * 0.15;
                    }
                    break;

                case "Tulips":
                    totall = tulipsPrice;
                    if (qty >= 80)
                    {
                        totall -= totall * 0.15;
                    }
                    break;

                case "Narcissus":
                    totall = narcisPrice;
                    if (qty < 120)
                    {
                        totall =  totall* 1.15;
                    }
                    break;

                case "Gladiolus":
                    totall = gladiPrice;
                    if (qty < 80)
                    {
                        totall = totall * 1.20;
                    }
                    break;
            }


            double moneyleft = budget - totall;

            //Проверяваме дали бюджета ще стигне и изпечатваме
            if (moneyleft>=0)
            {
                Console.WriteLine($"Hey, you have a great garden with {qty} {flower} and {moneyleft:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyleft):f2} leva more.");
            }

            //            Да се отпечата на конзолата на един ред:
            //•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            //Сумата да бъде форматирана до втория знак след десетичната запетая.




        }
    }
}
