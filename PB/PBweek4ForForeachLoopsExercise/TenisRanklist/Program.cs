using System;

namespace TenisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Григор Димитров е тенисист, чиято следваща цел е изкачването в световната ранглиста по тенис за мъже.
            //През годината Гришо участва в определен брой турнири, като за всеки турнир получава точки,
            //които зависят от позицията, на която е завършил в турнира.Има три варианта за завършване на турнир:
            //	W - ако е победител получава 2000 точки
            //	F - ако е финалист получава 1200 точки
            //	SF - ако е полуфиналист получава 720 точки

            //Напишете програма, която изчислява колко ще са точките на Григор след изиграване на всички турнири,
            //като знаете с колко точки стартира сезона.Също изчислете колко точки средно печели от всички изиграни
            //турнири и колко процента от турнирите е спечелил.


            //Вход
            //От конзолата първо се четат два реда:
            //•	Брой турнири, в които е участвал – цяло число в интервала[1…20] 
            //•	Начален брой точки в ранглистата - цяло число в интервала[1...4000]

            int turnirCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            //създаване и на променливи където да вписваме колко Wins Finals or Semi finals
            int w = 0;
            int f = 0;
            int sf = 0;
            int totalPonts = startingPoints;

            //За всеки турнир се прочита отделен ред:
            //•	Достигнат етап от турнира – текст – "W", "F" или "SF"
            for (int i = 0; i < turnirCount; i++)
            {
                string stage = Console.ReadLine();
                switch (stage) 
                {
                    case "W":
                        totalPonts += 2000;
                        w += 1;
                        break;
                    case "F":
                        totalPonts += 1200;
                        f += 1;
                        break;
                    case "SF":
                        totalPonts += 720;
                        sf += 1;
                        break;
                }

            }
            // изчислява колко ще са точките на Григор след изиграване на всички турнири,
            //като знаете с колко точки стартира сезона.Също изчислете колко точки средно печели от всички изиграни
            //турнири и колко процента от турнирите е спечелил.

                Console.WriteLine($"Final points: {totalPonts}");
            Console.WriteLine($"Average points: {Math.Floor(((double)totalPonts-startingPoints) / turnirCount)}");
            Console.WriteLine($"{(double)w/turnirCount*100:f2}%");
            //Изход
            //Отпечатват се три реда в следния формат:
            //•	"Final points: {брой точки след изиграните турнири}"
            //•	"Average points: {средно колко точки печели за турнир}"
            //•	"{процент спечелени турнири}%"
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу, а процентът да се форматира до втората цифра след десетичния знак.

        }
    }
}
