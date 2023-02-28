﻿using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Румен иска да пребоядиса хола и за целта е наел майстори. Напишете програма, която изчислява разходите за ремонта, предвид следните цени:
            //•	Предпазен найлон -1.50 лв.за кв. метър
            //•	Боя - 14.50 лв.за литър
            //•	Разредител за боя - 5.00 лв.за литър
            //За всеки случай, към необходимите материали, Румен иска да добави още 10 % от количеството боя и 2 кв.м.найлон, разбира се и 0.40 лв.за торбички. Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30 % от сбора на всички разходи за материали.

            //Вход
            //            Входът се чете от конзолата и съдържа точно 4 реда:
            //            1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100] int
            int nailon = int.Parse(Console.ReadLine())+2;
            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100] double
            double paint = double.Parse(Console.ReadLine());
            paint = paint + paint * 0.1;
            //3.Количество разредител(в литри) - цяло число в интервала[1…30] int
            int razreditel = int.Parse(Console.ReadLine());
            //часове работа
            double workerh = double.Parse(Console.ReadLine());


            // cena za vseki material
            double nilonPrice = nailon * 1.5;
            double paintPrice = paint * 14.5;
            double razreditelPrice = razreditel * 5;

            //Обща цена
            double totall = nilonPrice + paintPrice + razreditelPrice + 0.4;

            //cena za rabota
            double workingPrice = totall * 0.3;

            //Обща цена за материали и работа

            double tottalsum = totall + workingPrice * workerh;

            Console.WriteLine(tottalsum);



        }
    }
}
