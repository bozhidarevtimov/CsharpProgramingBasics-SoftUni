using System;

namespace NumbersNto1withStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n, въведено от потребителя и отпечатва числата от 1 до n през 3.
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i +=3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
