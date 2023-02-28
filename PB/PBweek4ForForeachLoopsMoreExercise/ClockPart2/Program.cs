using System;

namespace ClockPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да отпечатва часовете в денонощието от 0:0:0 до 23:59:59, всеки на отделен ред.
            //Часовете да се изписват във формат "{час} : {минути} : {секунди} ".

            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        Console.WriteLine($"{h} : {m} : {s}");
                    }
                }
            }

        }
    }
}
