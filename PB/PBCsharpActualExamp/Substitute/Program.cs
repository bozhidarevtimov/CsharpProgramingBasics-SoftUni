﻿using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Любимият отбор на Пепи е на финал, но започва да губи мача.

            //Треньорът на отбора не знае какви смени да направи, за да обърне резултата. 

            //Напишете програма, с която ще разберете кой са първите 6 валидни смени, които могат да се направят.  

            //Знаем, че всяка цифра от двата номера е в даден интервал:
            //•	Първата цифра на първото число е в интервала от цифрата K до 8, включително.
            //•	Втората цифра на първото число е в интервала от 9 до L, включително.
            //•	Първата цифра на второто число е в интервала от цифрата M до 8, включително.
            //•	Втората цифра на второто число е в интервала от 9 до N, включително.
            //За да бъде възможна една смяна, първата цифра на всеки от номерата трябва да бъде четна, а втората -нечетна.

            //За да бъде валидна една смяна, то номерата НЕ трябва да съвпадат.

            //Вход:
            //От конзолата се четат 4 реда:
            //•	K – цяло число в интервала[0..8]
            //•	L – цяло число в интервала[0..9]
            //•	M– цяло число в интервала[0..8]
            //•	N – цяло число в интервала[0..9]

            //Изход:
            //            На конзолата да се отпечатат първите 6 валидни смени по следния начин:
            //•	Ако смяната е възможна и номерата НЕ съвпадат, тя Е валидна и трябва да се отпечата:
            //            "{K}{L} - {M}{N}"
            //•	Ако смяната е възможна, но номерата съвпадат, тя НЕ е валидна и трябва да се отпечата:
            //"Cannot change the same player."


            //1.Четем 
            //•	K – цяло число в интервала[0..8]
            int K = int.Parse(Console.ReadLine());
            //•	L – цяло число в интервала[0..9]
            int L = int.Parse(Console.ReadLine());
            //•	M– цяло число в интервала[0..8]
            int M = int.Parse(Console.ReadLine());
            //•	N – цяло число в интервала[0..9]
            int N = int.Parse(Console.ReadLine());

            //променливи
            //валидни смени брояч
            int validSub = 0;
            //възбожна смяна
            int possibleSubNum1 = 0;
            int possibleSubNum2 = 0;

            //Знаем, че всяка цифра от двата номера е в даден интервал:
            //2. два for цикъла за двете числа за да намерим всички кобинацции за всяко число


            //•	Първата цифра на първото число е в интервала от цифрата K до 8, включително.
            //•	Втората цифра на първото число е в интервала от 9 до L, включително.
            for (int fNumF = K; fNumF <= 8 ; fNumF++)
            {

                for (int fNumS = 9; fNumS >= L; fNumS--)
                {
                    //•	Първата цифра на второто число е в интервала от цифрата M до 8, включително.
                    //•	Втората цифра на второто число е в интервала от 9 до N, включително.
                    for (int sNumF = M; sNumF <= 8; sNumF++)
                    {
                        for (int sNumS = 9; sNumS >= N; sNumS--)
                        {
                            
                            //За да бъде възможна една смяна, първата цифра на всеки от номерата трябва да бъде четна, а втората -нечетна.
                            //За да бъде валидна една смяна, то номерата НЕ трябва да съвпадат.

                            //На конзолата да се отпечатат първите 6 валидни смени по следния начин:
                            //•	Ако смяната е възможна и номерата НЕ съвпадат, тя Е валидна и трябва да се отпечата:
                            //            "{K}{L} - {M}{N}"
                            //•	Ако смяната е възможна, но номерата съвпадат, тя НЕ е валидна и трябва да се отпечата:
                            //"Cannot change the same player."
                            if (validSub < 6)
                            {


                                if ((fNumF % 2 == 0 && fNumS % 2 != 0) && (sNumF % 2 == 0 && sNumS % 2 != 0))
                                {
                                    if ((fNumF == sNumF) && (fNumS == sNumS))
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{fNumF}{fNumS} - {sNumF}{sNumS}");
                                        validSub++;
                                    }

                                }
                            }

                        }
                    }
                }
            }

            



        }
    }
}
