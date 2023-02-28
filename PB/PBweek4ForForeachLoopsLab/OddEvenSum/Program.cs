using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
 //Да се напише програма, която чете n-на брой цели числа, подадени от потребителя и проверява дали
 //сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции.
 //•	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
 //•	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата.
 //Разликата се изчислява по абсолютна стойност. 

            int boriNumbers = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < boriNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += currentNumber;
                }
                else 
                {
                    odd += currentNumber;
                }

            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(odd - even)}");
            }


        }
    }
}
