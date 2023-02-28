﻿using System;

namespace PointOnRectangelBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която проверява дали точка { x, y}
            // се намира върху някоя от страните на правоъгълник { x1, y1} – { x2, y2}.

            // Входните данни се четат от конзолата и се състоят от 6 реда въведени от потребителя: 
            //десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1 < y2).

            //Да се отпечата "Border"(точката лежи на някоя от страните) или "Inside / Outside"(в противен случай).

            //1.Четем десетичните числа x1, y1, x2, y2, x и y от конзолата
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
            {
                Console.WriteLine("Border");
            }
            else 
            {
                Console.WriteLine("Inside / Outside");
            }

            // *Подсказка: използвайте една или няколко условни if проверки с логически операции.Точка { x, y}
            // лежи върху някоя от страните на правоъгълник { x1, y1} – { x2, y2}, ако е изпълнено едно от следните условия:
            //•	x съвпада с x1 или x2 и същевременно y е между y1 и y2
            //•	y съвпада с y1 или y2 и същевременно x е между x1 и x2
            //Можете да проверите горните условия с една по-сложна if-else конструкция или 
            // с няколко по - прости проверки или с вложени if-else проверки.

        }
    }
}
