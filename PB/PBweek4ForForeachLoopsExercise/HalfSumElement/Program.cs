using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя,
            //и проверява дали сред тях съществува число, което е равно на сумата на всички останали. 

            //•	Ако има такъв елемент печата "Yes" и на нов ред "Sum = " + неговата стойност
            //•	Ако няма такъв елемент печата "No" и на нов ред
            //"Diff = " + разликата между най-големия елемент и сумата на останалите(по абсолютна стойност)

            //четем от конзола броят числа които ще се въведат
            int countNumbers = int.Parse(Console.ReadLine());
            //създавам променлива за сумата от числата и за най голямото
            int sum = 0;
            //променливата за най голямото е равна на minValue за int в C# за да подсигорим първата проверка 
            int maxNum = int.MinValue;


            //правим цикъл който да се върти колцота е countNumbers въведен от потребителя
            for (int i = 1; i <= countNumbers ; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;//добавяме въведеното число към sum
                if (currentNumber > maxNum)//проверка дали е по голямо от int maxNum числото
                      //и го записваме в  int maxNum ako e
                {
                    maxNum = currentNumber;
                }
            }

            //калкулираме sum - maksNum  и по доло казваме че ако резултата е = на maxNum, занчи maxNum е колкото другите заедно 
            //ако не  maxNum - резултата ще даде разликата между най голямото и сбора на другите
            int result = sum - maxNum;
            int diffrents = maxNum - result;

            if (result == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {result}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diffrents)}");

            }
            
        }
    }
}
