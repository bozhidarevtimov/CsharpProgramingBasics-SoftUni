﻿using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете две цели числа(N1 и N2) и оператор, с който да се
            //извърши дадена математическа операция с тях.Възможните операции са:
            //Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
            //При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и
            //дали той е четен или нечетен.При обикновеното деление – резултата.При модулното деление – остатъка.
            //Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели.
            //В този случай трябва да се отпечата специално съобщениe.


            //Вход
            //От конзолата се прочитат 3 реда, въведени от потребителя:
            //•	N1 – цяло число в интервала[0...40 000]
            int N1 = int.Parse(Console.ReadLine());
            //•	N2 – цяло число в интервала[0...40 000]
            int N2 = int.Parse(Console.ReadLine());
            //•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            char operaitor = char.Parse(Console.ReadLine());

            //Проверяваме какв е оператора и извършваме действието 
            //като при + – * след резултата изваждаме на конзолата odd or even
            //а при деление проверяваме дали N2 не е 0 при което изписваме на конзолата че числото не се дели
            if (operaitor == '+' || operaitor == '-' || operaitor == '*')
            {
                //променлива за резултат която използваме по долу
                int result;
                //променлива string за проверка на четен или нечетен резултат която по default пишем odd,
                //no променяме при проверката по доло ако е even
                string oddEven = "odd";
                if (operaitor=='+')
                {
                    result = N1 + N2;
                }
                else if (operaitor=='-')
                {
                    result = N1 - N2;
                }
                else // *
                {
                    result = N1 * N2;

                }
                if (result%2==0)
                {
                    oddEven="even";

                }
                Console.WriteLine($"{N1} {operaitor} {N2} = {result} - {oddEven}");
            }
           // при деление проверяваме дали N2 не е 0 при което изписваме на конзолата че числото не се дели
            else //Което знаем че не е  + - *  а ще бъде едно от двете деления operaitor=='/'|| operaitor == '%'
            {
                if (N2 != 0)
                {
                    double result;
                    if (operaitor == '/')
                    {
                        //кастваме с (double) пред първото число защото двете са int, а резултата ще бъде double.
                        result = (double)N1 / N2;
                        Console.WriteLine($"{N1} {operaitor} {N2} = {result:f2}");
                    }
                    else
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} {operaitor} {N2} = {result}");
                    }
                }
                else 
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }


            //Изход
            //Да се отпечата на конзолата един ред:
            //•	Ако операцията е деление:
            //o   "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            //•	Ако операцията е модулно деление:
            //            o   "{N1} % {N2} = {остатък}"
            //•	В случай на деление с 0(нула): 
            //o   "Cannot divide {N1} by zero"

        }
    }
}
