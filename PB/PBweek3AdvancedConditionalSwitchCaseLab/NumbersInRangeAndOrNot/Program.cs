using System;

namespace NumbersInRangeAndOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали въведеното от потребителя число е в интервала
            //[-100, 100] и е различно от 0 и извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.

            int num = int.Parse(Console.ReadLine());
            //ако num не е равно на нула
            if (num != 0)
            {
                //ако num e по гоямо от -100 И && num e по малко или равно на 100
                if (num >= -100 && num <= 100)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
