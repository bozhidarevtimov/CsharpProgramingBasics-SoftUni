using System;

namespace FootbalLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            // От конзолата се четат поредица от числа, всяко на отделен ред:

            //1.Капацитетът на стадиона – цяло число в интервала[1 … 10000];
            //2.Броят на всички фенове – цяло число в интервала[1 … 10000].

            //За всеки един фен, на отделен ред се прочита:
            //1.Секторът, на който се намира – текст – "A", "B", "V" и "G".

            //Изход
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 %, форматирани до втората цифра след десетичната запетая:
            //1.Процентът на феновете в сектор А
            //2.Процентът на феновете в сектор Б
            //3.Процентът на феновете в сектор В
            //4.Процентът на феновете в сектор Г
            //5.Процентът на всички фенове, спрямо капацитета на стадиона.


            //1. Четем
            //Капацитетът на стадиона – цяло число в интервала[1 … 10000];
            int capacity = int.Parse(Console.ReadLine());
            //Броят на всички фенове – цяло число в интервала[1 … 10000].
            int fans = int.Parse(Console.ReadLine());

            //променливи
            //броячи за феновете в определени сектори
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            //Сбор на феновете във всички сецтори
            int allFans = 0;

            //2.Четем //За всеки един фен, на отделен ред се прочита:
            //Секторът, на който се намира – текст – "A", "B", "V" и "G".
            //правим си променлива за сектор която ще ползваме за да четем в цикъла
            string sector = "";
            for (int i = 0; i < fans; i++)
            {
                sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }
            //Калкулираме и общият брой
            allFans = sectorA + sectorB + sectorG + sectorV;

            //Да се отпечатат на конзолата 5 реда, всеки от които съдържапроцента на феновете в сектор спрямо всички фенове, форматирани до втората цифра след десетичната запетая:
            //процента на феновете в сектор спрямо всички фенове (феновете в сецтора/всички фенове по 100)
            //1.Процентът на феновете в сектор А
            Console.WriteLine($"{((double)sectorA/(double)allFans)*100:f2}%");
            //2.Процентът на феновете в сектор Б
            Console.WriteLine($"{((double)sectorB / (double)allFans) * 100:f2}%");
            //3.Процентът на феновете в сектор В
            Console.WriteLine($"{((double)sectorV / (double)allFans) * 100:f2}%");
            //4.Процентът на феновете в сектор Г
            Console.WriteLine($"{((double)sectorG / (double)allFans) * 100:f2}%");
            //5.Процентът на всички фенове, спрямо капацитета на стадиона.(всички фенове/капацитета по 100)
            Console.WriteLine($"{((double)allFans / (double)capacity) * 100:f2}%");
        }
    }
}
