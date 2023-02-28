using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете n на брой цели числа.
            //Принтирайте най-голямото и най-малкото число сред въведените.

            int boriNumbers = int.Parse(Console.ReadLine());

///Сетваме променливата за максимум на стойноста за минималната стойност за int
///и променливата за минимум на стойноста за максималнатастойност на int
/////Taka отдолу при проверката може да подсигурим че променливата за maxNumber e винаги по голяма от
///минимланата стойност na int в C#, a променливата за minNumber e по малка от максималната стойност на int в C#
///TОВА СЕ ПРАВИ С ЦЕЛ ДА ПОДСИГУРИМ ПЪРВАТА ПРОВЕРКА ПО ДОЛУ, ТЪЙ КАТО АКО ПРОСТО СЕТНЕМ 0 ИЛИ ДРУГО ЧИСЛО
///КЪМ max number  А ВЪВЕДЕНОТО ЧИСЛО ОТ КОНЗОЛАТА Е -10 ОТ ТАМ НАТАТЪК НЯМА ДА МОЖЕМ ДА СЕТНЕМ
///currentNumber към maxNumber
///СЛЕД КАТО ПОДСИГОРИМ ПЪРВАТА ПРОВЕРКА И ТОВА ЧЕ ВУВЕДЕНОТО ЧИСЛО ОТ КОНЗОЛАТА НЯМА ДА БЪДЕ ПО МАЛКО
///ОТ МИНИМЛАНОТО ВЪЗМОЖНО ЗА int в C#, СЕТВАМЕ ВЪВЕДЕНОТО ЧИСЛО КЪМ maxNumber И ОТ ТАМ НАТАТЪК
///ПРОВЕРКАТА if (curentNumber > maxNumber) РАБОТИ АДЕКВАТНО. И СЪЩОТО ЗА minNumber.
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;



            for (int i = 0; i < boriNumbers; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                /////Пподсигуряваме че променливата за maxNumber e винаги по голяма от
                ///минимланата стойност na int в C#, a променливата за minNumber e по малка от
                ///максималната стойност на int в C#
                if (curentNumber > maxNumber)
                {
                    maxNumber = curentNumber;
                }
                if (curentNumber < minNumber)
                {
                    minNumber = curentNumber;
                }

            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
