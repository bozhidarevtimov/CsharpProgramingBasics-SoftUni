using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са n цели числа в интервала [1…1000]. От тях някакъв процент p1 са под 200, друг процент
            //p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент p4 са от 600 до 799 и
            //останалите p5 процента са от 800 нагоре. Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
            //Пример: имаме n = 20 числа: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65.Получаваме следното разпределение и визуализация:
            // Вход
            // На първия ред от входа стои цялото число n(1 ≤ n ≤ 1000) – брой числа.
            // //На следващите n реда стои по едно цяло число в интервала[1…1000] –
            // //числата върху които да бъде изчислена хистограмата.
            int countNumbers = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <=countNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399) 
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4++;
                }
                else if (currentNumber >= 800)
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 / countNumbers * 100:f2}%");
            Console.WriteLine($"{p2 / countNumbers * 100:f2}%");
            Console.WriteLine($"{p3 / countNumbers * 100:f2}%");
            Console.WriteLine($"{p4 / countNumbers * 100:f2}%");
            Console.WriteLine($"{p5 / countNumbers * 100:f2}%");
            //Изход
            //Да се отпечата на конзолата хистограмата – 5 реда, всеки от които съдържа число между 0 % и 100 %, с точност две цифри след десетичната точка, например 25.00 %, 66.67 %, 57.14 %.

        }
    }
}
