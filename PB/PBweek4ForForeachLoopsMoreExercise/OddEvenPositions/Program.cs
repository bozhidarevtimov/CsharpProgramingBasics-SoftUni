using System;

namespace OddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете n-на брой числа, въведени от потребителя, и пресмята сумата,
            //минимума и максимума на числата на четни и нечетни позиции (броим от 1).
            //Когато няма минимален / максимален елемент, отпечатайте "No". 
            //Изходът да се форматира в следния вид:
            //"OddSum=" + { сума на числата на нечетни позиции},
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            //"EvenSum=" + { сума на числата на четни позиции },
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            //Всяко число трябва да е форматирано до втория знак след десетичната запетая.

            //1. Четем колко числа ще бъдат изписани
            int numbers = int.Parse(Console.ReadLine());

            //promenlivi

            double OddSum = 0;
            double OddMin = int.MaxValue; ;
            double OddMax = int.MinValue; ;
            double EvenSum = 0;
            double EvenMin = int.MaxValue;
            double EvenMax = int.MinValue;

            //2. правим цикъл в който ще четем числа колкото ни е дадено по горе в numbers
            //правим си променлива към която ще присвояваме прочетеното
            double currentNumber = 0;
            for (int i = 1; i <= numbers; i++)
            {
                currentNumber = double.Parse(Console.ReadLine());
                //проверяваме дали числото е на четна позиция
                if (i%2==0)
                {
                    //ako да добавяме стойноста на сегашният номер към сумата на четните
                    EvenSum += currentNumber;
                    //ако сегашният номер е по голям от EvenMax присвояваме стойноста му към EvenMax. така запазваме максималната стойност въведена на четна позиция
                    if (currentNumber > EvenMax)
                    {
                        EvenMax = currentNumber;
                    }
                    //правим същото за минимална стойност
                    if (currentNumber<EvenMin)
                    {
                        EvenMin = currentNumber;
                    }
                }
                //този else е за първияят if  тоест ако числото модулно не се дели на 2 с остатък 0 демек е нечетно
                else
                {
                    OddSum += currentNumber;
                    if (currentNumber > OddMax)
                    {
                        OddMax = currentNumber;
                    }
                    
                    if (currentNumber < OddMin)
                    {
                        OddMin = currentNumber;
                    }
                }

            }

            //Изходът да се форматира в следния вид:

            //Ako въведеното число е 1 и няма четни позиции да се отпечата "No" на EvenMax и EvenMin
            //и ако няма въведени числа тоест 0 да се изпечата "No" и за четни и за нечетни
            //"OddSum=" + { сума на числата на нечетни позиции},
            Console.WriteLine($"OddSum={OddSum:f2},");
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            if (OddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else 
            {
                Console.WriteLine($"OddMin={OddMin:f2},");
            }

            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            if (OddSum == 0)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            //"EvenSum=" + { сума на числата на четни позиции },
            Console.WriteLine($"EvenSum={EvenSum:f2},");
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            if (EvenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
            }
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            if (EvenSum == 0)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
            //Всяко число трябва да е форматирано до втория знак след десетичната запетая.
        }
    }
}
