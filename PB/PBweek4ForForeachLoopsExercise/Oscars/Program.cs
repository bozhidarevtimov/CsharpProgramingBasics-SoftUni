﻿using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поканени сте от академията да напишете софтуер, който да пресмята точките за актьор/ актриса.
            // Академията ще ви даде първоначални точки за актьора.След това всеки оценяващ ще дава своята оценка.
            // Точките, които актьора получава се формират от: дължината на името на оценяващия умножено по точките,
            // които дава делено на две. 

            //Ако резултатът в някой момент надхвърли 1250.5 програмата трябва да прекъсне и да се отпечата,
            //че дадения актьор е получил номинация.


            //Вход
            //•	Име на актьора - текст
            //•	Точки от академията - реално число в интервала[2.0... 450.5]
            //•	Брой оценяващи n - цяло число в интервала[1… 20]
            //На следващите n - на брой реда:
            //o Име на оценяващия -текст
            //o Точки от оценяващия -реално число в интервала[1.0... 50.0]
            string actor = Console.ReadLine();
           double points = double.Parse(Console.ReadLine());
            int graders = int.Parse(Console.ReadLine());
 

            for (int i = 1; i <= graders; i++)
            {
                string graderName = Console.ReadLine();
                double graderPoints = double.Parse(Console.ReadLine());
                graderPoints = (graderName.Length * graderPoints) / 2;
                points += graderPoints;
                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points < 1250.5) 
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5-points:f1} more!");
            }




//Изход
//Да се отпечата на конзолата един ред:
//•	Ако точките са над 1250.5:
//"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
//•	Ако точките не са достатъчни:
//            "Sorry, {име на актьора} you need {нужни точки} more!"
//Резултатът да се форматирана до първата цифра след десетичния знак!

        }
    }
}
