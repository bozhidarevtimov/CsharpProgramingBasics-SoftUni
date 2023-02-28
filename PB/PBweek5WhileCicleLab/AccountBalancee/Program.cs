using System;

namespace AccountBalancee
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Напишете програма, която пресмята колко общо пари има в сметката, 
            ///след като направите определен брой вноски. На всеки ред ще получавате сумата, 
            ///която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" .
            ///При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя 
            ///в сметката. Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!"
            ///и програмата да приключи. Когато програмата приключи трябва да се принтира
            ///"Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 
            ///

            ////Tъй като имаме миксиран вход от конзолата, първо правим стринг който да се чете от конзолата,
            ///а след това в while цикъла ще го парснем.
            string input = Console.ReadLine();
            double totall = 0;

            while (input != "NoMoreMoney")
            {
                ///Ако стринга не е  NoMoreMoney правим си роменлива double и парсваме текста към double за да можем да го използваме за изчесление.
                double deposit = double.Parse(input);

                ////проверка за сумата ако е под 0
                ///
                if (deposit<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totall += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
                input = Console.ReadLine(); 
            }

            Console.WriteLine($"Total: {totall:f2}");

        }
    }
}
