using System;

namespace NumbersEndig7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва числата в диапазона от 1 до 1000, които завършват на 7.

            //първи вариант с проверка ако числото се дели модулно на 10 с остатък 7

            //{
            //    for (int i = 1; i <= 1000; i++)
            //    {
            //        if (i%10==7)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //Втори вариант започваме от 7 и увеличваме с 10
            for (int i = 7; i < 997; i += 10)
            {
                Console.WriteLine(i);
            }

        }
    }
}
