﻿using System;

namespace Celsius_to_Farenhai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете градуси по скалата на Целзий(°C) и ги преобразува 
            //  до градуси по скалата на Фаренхайт(°F).Потърсете в Интернет подходяща формула, с
            //която да извършите изчисленията. Форматирате изхода до втория
            //знак след десетичната запетая. 

            //чете градуси по скалата на Целзий(°C)

            double celsius = double.Parse(Console.ReadLine());

            // и ги преобразува до градуси по скалата на Фаренхайт(°F).
            //Потърсете в Интернет подходяща формула, с която да извършите изчисленията.
            // (0°C × 9 / 5) +32 = 32°F
            double farenhai = (celsius * 9 / 5) + 32;
            // Форматирате изхода до втория знак след десетичната запетая. 
            Console.WriteLine(farenhai.ToString("0.00"));

        }
    }
}
