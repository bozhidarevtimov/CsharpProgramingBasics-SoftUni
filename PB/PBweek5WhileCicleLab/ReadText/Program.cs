using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Напишете програма, която чете текст от конзолата (стринг) и го принтира,
            ///докато не получи командата "Stop".
            ///

            //string word = Console.ReadLine();
            //while (word != "Stop")
            //{
            //    Console.WriteLine(word);
            //    word = Console.ReadLine();

            //}

            ////Различен начин
            ///
            /////Правим си празна променлива от стринг 
            ////и в скобките на while цикъла слагаме скоби за приоритизация, което се доближава до for цикъла
            ////Казваме while и позаме Consle.ReadLine  != "Stop"  прави това

            string word;
            while ((word = Console.ReadLine()) != "Stop" )
            {
                Console.WriteLine(word);
            }

        }
    }
}
