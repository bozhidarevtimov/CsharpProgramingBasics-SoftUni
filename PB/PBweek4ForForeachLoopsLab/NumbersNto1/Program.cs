﻿using System;
using System.Collections.Generic;
namespace NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя и печата числата
            //от n до 1 в обратен ред.Въведеното число n, винаги ще бъде по-голямо от 1.

            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >=1; i--)
            {

                Console.WriteLine(i);
                


            }


        }
    }
}
