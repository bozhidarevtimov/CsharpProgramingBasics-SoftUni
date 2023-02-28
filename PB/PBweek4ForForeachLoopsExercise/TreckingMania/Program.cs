using System;

namespace TreckingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            // Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване.
            // Според размера на групата, катерачите ще изкачват различни върхове.
            //•	Група до 5 човека – изкачват Мусала
            //•	Група от 6 до 12 човека – изкачват Монблан
            //•	Група от 13 до 25 човека – изкачват Килиманджаро
            //•	Група от 26 до 40 човека –  изкачват К2
            //•	Група от 41 или повече човека – изкачват Еверест
            //Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.


            //Вход
            //От конзолата се четат поредица от числа, всяко на отделен ред:
            //•	На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //•	За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            int groups = int.Parse(Console.ReadLine());
            int groupOf5 = 0;
            int groupOf6to12 = 0;
            int groupOf13to25 = 0;
            int groupOf26to40 = 0;
            int groupOf41orMore = 0;
            for (int i = 1; i <= groups; i++)
            {
                int treckers = int.Parse(Console.ReadLine());
                if (treckers <= 5)
                {
                    groupOf5 += treckers;
                }
                else if (treckers <= 12)
                {
                    groupOf6to12 += treckers;
                }
                else if (treckers <= 25)
                {
                    groupOf13to25 += treckers;
                }
                else if (treckers <= 40)
                {
                    groupOf26to40 += treckers;
                }
                else if (treckers >= 41)
                {
                    groupOf41orMore += treckers;
                }

            }

            //изчисляваме колко са всички хора за да използваме резултата да определим колко процента на всеки връх.
            int allTreckers = groupOf5 + groupOf6to12 + groupOf13to25 + groupOf26to40 + groupOf41orMore;
            //•	Група до 5 човека – изкачват Мусала
            //•	Група от 6 до 12 човека – изкачват Монблан
            //•	Група от 13 до 25 човека – изкачват Килиманджаро
            //•	Група от 26 до 40 човека –  изкачват К2
            //•	Група от 41 или повече човека – изкачват Еверест

            //Изход
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 % с точност
            //до втората цифра след десетичната запетая.
            //•	Първи ред -процентът изкачващи Мусала
            //•	Втори ред – процентът изкачващи Монблан
            //•	Трети ред – процентът изкачващи Килиманджаро
            //•	Четвърти ред – процентът изкачващи К2
            //•	Пети ред – процентът изкачващи Еверест
            Console.WriteLine($"{(double)groupOf5 / allTreckers*100:f2}%");
            Console.WriteLine($"{(double)groupOf6to12 / allTreckers * 100:f2}%");
            Console.WriteLine($"{(double)groupOf13to25 / allTreckers * 100:f2}%");
            Console.WriteLine($"{(double)groupOf26to40 / allTreckers * 100:f2}%");
            Console.WriteLine($"{(double)groupOf41orMore / allTreckers * 100:f2}%");

        }
    }
}
