﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
//            Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
//•	От първия ред на входа се въвежда броят числа n.
//•	От следващите n реда се въвежда по едно цяло число.
//Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 


            int boriNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < boriNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum = numbers + sum;
            }
            Console.WriteLine(sum);

        }
    }
}
