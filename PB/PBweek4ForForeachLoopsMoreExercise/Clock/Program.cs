using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която отпечатва часовете в денонощието от 0:0 до 23:59, всеки на отделен ред. 
            //  Часовете трябва да се изписват във формат "{час} : {минути}".

            for (int h = 0; h <=23 ; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h} : {m}");
                }
            }
        }
    }
}
