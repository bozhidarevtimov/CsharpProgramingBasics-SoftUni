﻿using System;

namespace Safe_password_generation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ани се страхува от това, да не й бъде хакнат някой от профилите в социалните мрежи,
            //затова решава да направи генератор за пароли, които да бъдат достатъчно сигурни.

            //Вашата задача е да й помогнете да напише програма, която ще генерира тези пароли,
            //разделени една от друга от знака "|".

            //Да се напише програма, която генерира серия от символи като в шаблона:
            // ABxyBA
            // като при всяко генериране на нов код, стойностите на символите се увеличават с 1.
            //Ако A надхвърли 55, се връща на 35.Ако B надхвърли 96, се връща на 64.

            //Вход
            //От конзолата се чете 1 ред:
            //•	На първия ред a – цяло число в интервала[1 … 1000]
            //•	На втория ред b – цяло число в интервала[1 … 1000]
            //•	На третия ред максимален брой генерирани пароли – цяло число в интервала[1 … 1000000]
            //Ограничения:
            //•	A е символ с ASCII стойност в диапазона[35… 55]
            //•	B е символ с ASCII стойност в диапазона[64 … 96]
            //•	x e цяло число в диапазона[1… a] 
            //•	y e цяло число в диапазона[1… b]

            //Изход:
            //            Да се отпечата на конзолата:
            //•	Генерираният код. Ако броят на комбинациите е по-голям от максималния на кода(максимален брой генерирани пароли)да се отпечата до подадената стойност, в противен случай да се отпечата до текущия брой на комбинациите.
            //(комбинациите които биха злезнали при въртене на циклите при въведените стойности (а) и (b)), да се отпечата до подадената стойност, в противен случай да се отпечата до текущия брой на комбинациите.
            ////разделени една от друга от знака "|".



            //Да се напише програма, която генерира серия от символи като в шаблона:
            // ABxyBA
            // като при всяко генериране на нов код, стойностите на символите се увеличават с 1.
            //Ако A надхвърли 55, се връща на 35.Ако B надхвърли 96, се връща на 64.

            //1. Четем
            //•	На първия ред a – цяло число в интервала[1 … 1000]
            int a = int.Parse(Console.ReadLine());
            //•	На втория ред b – цяло число в интервала[1 … 1000]
            int b = int.Parse(Console.ReadLine());
            //•	На третия ред максимален брой генерирани пароли – цяло число в интервала[1 … 1000000]
            int maxCombinations = int.Parse(Console.ReadLine());

            //променливи за всеки символ от шаблона за парола ABxyBA
            //Ограничения:
            //•	A е символ с ASCII стойност в диапазона[35… 55]
            char A = (char)35;
            //•	B е символ с ASCII стойност в диапазона[64 … 96]
            char B = (char)64;

            //•	x e цяло число в диапазона[1… a]
            int x = 1;//до въведеното число от конзолата (а)
            //•	y e цяло число в диапазона[1… b]
            int y = 1; //до въведеното число от конзолата(b)

            //брояч за комбинациите
            int combinations = 0;
            //променлива за кобницаиите от x и y
            

            //Малко е объркано обяснението, но мисля че циклите са всички комбинации с от  (a) до (b)
            //тоест ако (a) до (b)  са 2и3 комбинациите ще са 5 и програмата трябва да спре  ако пък са 20 и 50 но максималният
            //брой генерирани пароли ни е прочетено че ще са 10 тябва да спрем на 10тата комбинация

            //Ако е така правим два цикъла единият започващ от 1 и свършващ с (а) другият с (b)
            // и вътре ще проверяваме за максималният брой пароли
            for (int f = 1; f <=a ; f++)
            {
                for (int s = 1; s <=b ; s++)
                {
                    //проверяваме дали не сме достигнали максималният брой комбинации
                    if (combinations<maxCombinations)
                    {
                        Console.Write($"{A}{B}{x}{y}{B}{A}|");
                        // като при всяко генериране на нов код, стойностите на символите се увеличават с 1.
                        //Ако A надхвърли 55, се връща на 35.Ако B надхвърли 96, се връща на 64.
                        A++;
                        B++;
                        //проверяваме дали А и B не са достигнали зададените ни стойности ако да ги рестартираме
                        if (A>55)
                        {
                            A = (char)35;
                        }
                        if (B>96)
                        {
                            B = (char)64;
                        }
                        //тук трябва да проверим дали  (x) и (y) са равни на стойностите на (а) и (b)
                        //за да се увеличват за следващата парола ако не са.
                        // и да се връщат обратно на 1 ако са 
                        //Така май работи увеличаваме у всеки път, ако стане по голямо от b го правим едно и увеличаваме х ако то стане по голямо от а го правим на 1
                        //и така се въртят
                        y++;
                        if (y>b)
                        {
                            y = 1;
                                x++;
                            if (x>a)
                            {
                                x = 1;
                            }
                        }

                        //увеличаваме изписаните комбинации с 1
                        combinations++;
                    }

                }
            }


        }
    }
}
