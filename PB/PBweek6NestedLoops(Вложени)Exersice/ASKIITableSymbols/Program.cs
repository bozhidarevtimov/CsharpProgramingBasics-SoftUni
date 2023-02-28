using System;

namespace ASKIITableSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //четат се 2 цели числа а1 и а2
            //символ с ASKII код от а1 до а2 -1

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());

            //пускаме цикъл който да започва от а1 и завуршва на а2
            //ако кастнем i към char и кастнем а1 и а2 към char ще получим стойноста на а1 и а2 в ASKII таблицата
            for (char i = (char)a1; i <= (char)a2 ; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
