﻿using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поздравления, поради вашите задълбочени знания в сферата на програмирането
            //МВР реши да наеме точно вас за създаването на новата им система за генериране на специални автомобилни номера.

            //Всеки един специален автомобилен номер се състой от четири числа.
            //Условията, които разграничават специалните от обикновените номера са следните: 
            //•	Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и обратното – ако започва с нечетна, завършва на четна
            //•	Първата цифра от номера е по-голяма от последната
            //•	Сумата от втората и третата цифра трябва да е четно число

            //Входа се състой от две числа - начало и край на интервал, между които трябва да се генерира всяко едно число от номера.
            //Вход
            //1.Първи ред - едноцифрено число - началото на интервала – цяло число в интервала[1…9]
            //2.Втори ред - едноцифрено число - края на интервала – цяло число в интервала[1…9]
            //Изход
            //На конзолата трябва да се отпечатат всички специални номера, разделени с интервал.

            //1.Четем начало и край на интервала между които трябва да се генерира всяко едно число от номера.
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            //правим 1 цикъл с 3 вложени с начало променливата begin и край променливата end
            //за да получим всички 4 цифрени комбинации с числата от begin до end
            for (int first = begin; first <= end; first++)
            {
                for (int second = begin; second <= end; second++)
                {
                    for (int third = begin; third <= end; third++)
                    {
                        for (int forth = begin; forth <= end; forth++)
                        {
                            //Условията, които разграничават специалните от обикновените номера са следните: 
                            //•	Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и обратното – ако започва с нечетна, завършва на четна
                            //•	Първата цифра от номера е по-голяма от последната
                            //•	Сумата от втората и третата цифра трябва да е четно число
                            if ((first % 2 == 0 && forth % 2 != 0) && (first > forth) && ((second + third) % 2 == 0))
                            {
                                Console.Write($"{first}{second}{third}{forth} ");
                            }
                            if ((first % 2 != 0 && forth % 2 == 0) && (first > forth) && ((second + third) % 2 == 0))
                            {
                                Console.Write($"{first}{second}{third}{forth} ");
                            }

                        }
                    }
                }

            }
        }
    }
}
