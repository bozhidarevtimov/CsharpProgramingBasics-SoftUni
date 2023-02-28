using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
            //"{първи множител} * {втори множител} = {резултат}".


            ///Първият цикъл сравнява първият номер започващ от 1 с 10 и докато е по малко или равно увеличава първият номер 
            ///започва да се върти като в него е вторият цикъл сравнява вторият номер започващ от 1 с 10
            ///така първият цикъл се върти докато 1*1,1*2....1*10. после 2*1, 2*2.. 2*10.. и така до 10*1,10*2...10*10.
            for (int firstNum = 1; firstNum <=10 ; firstNum++)
            {
                for (int seondNum = 1; seondNum <=10; seondNum++)
                {
                    int result = firstNum * seondNum;
                    Console.WriteLine($"{firstNum} * {seondNum} = {result} ");
                }
            }

        }
    }
}
