using System;

namespace NumbersFrom1to100
{
    class Program
    {
        static void Main(string[] args)
        {

            ////For цикъла приема 3 параметъра
            ///int i = 0; инициализация(даваме начало на цикъла като създаваме променлива int равна на нула)
            ///
            ///i < Lenght; условие за краят на цикъла.Ако върне true цикъла свършва
            ///(Казваме че цикъла е се върти докато int i стане по малко от друга променлива в кода)
            ///
            ///i++; стъпка на цикъла. Действието което се извършва с i при всяко завъртане
            ///(в случаят постинкрементация(което ще увеличи i с 1 след като се изпълни кода долу в блока от код))
            ///за да може в един момент да се изпълни условието за край
            ///

            //for (int i = 0; i < length; i++)
            //{

            //}



            //Напишете програма, която отпечатва числата от 1 до 100, всяко на нов ред.
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
