using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете цяло число, въведено от потребителя, и печата дали е четно или нечетно. 
            //Ако е четно отпечатайте "even", ако е нечетно "odd".


            //чете цяло число
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
        }
    }
}
