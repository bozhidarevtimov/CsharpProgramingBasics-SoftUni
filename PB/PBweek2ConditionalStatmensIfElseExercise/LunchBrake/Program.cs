using System;

namespace LunchBrake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно
            //време да изгледате епизода. По време на почивката отделяте време за обяд и време за отдих.
            //Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде
            //1/4 от времето за почивка. 


            //От конзолата се четат 3 реда:
            //1.Име на сериал – текст
            string movie = Console.ReadLine();
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            int duration = int.Parse(Console.ReadLine());
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120]
            int brakeTime = int.Parse(Console.ReadLine());

            // По време на почивката отделяте време за обяд и време за отдих.
            //Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде
            //1/4 от времето за почивка. (5/8 общо от цчлата почивка)
            double timeLeft = (double)brakeTime * 5 / 8.0;

            //•	Ако времето е достатъчно да изгледате епизода:
            //Времето да се закръгли до най-близкото цяло число нагоре.
            //"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            //•	Ако времето не Ви е достатъчно:
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            if (timeLeft>=duration)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(timeLeft-duration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(duration-timeLeft)} more minutes.");
            }


        }
    }
}
