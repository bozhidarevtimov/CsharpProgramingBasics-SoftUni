using System;

namespace TopBotomSum
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Да се напише програма, която чете 2 * n - на брой цели числа, подадени от потребителя,
            ///и проверява дали сумата на първите n числа(горна сума) е равна на сумата на 
            ///вторите n числа(долна сума). При равенство печата " Yes, sum = " + сумата; 
            ///иначе печата " No, diff = " + разликата.
            ///Разликата се изчислява като положително число(по абсолютна стойност).
            ///
            int n = int.Parse(Console.ReadLine());
            int topSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                topSum += currentNumber;
            }

            int bottomSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                bottomSum += currentNumber;
            }

            // TODO: read and calculate the rightSum
            if (topSum == bottomSum)
            {
                Console.WriteLine("Yes, sum = " + bottomSum);
            }
            else
            {
                int diff = Math.Abs(bottomSum - topSum);
                Console.WriteLine("No, diff = " + diff);
            }




        }
    }
}
