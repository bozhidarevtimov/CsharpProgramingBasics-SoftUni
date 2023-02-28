using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете две цели числа въведени
            //от потребителя и отпечатва по-голямото от двете. 

            //чете две цели числа въведени

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //отпечатва по-голямото от двете.
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }

        }
    }
}
