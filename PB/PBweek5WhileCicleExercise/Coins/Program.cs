using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            // Производителите на вендинг машини искали да направят машините си да връщат възможно
            // най - малко монети ресто. Напишете програма, която приема сума -рестото, което трябва
            // да се върне и изчислява с колко най-малко монети може да стане това.

            ///Moнети от 2лв кочто е 200стотинки, от 1лв което са 100ст, 50ст,20ст,10ст,5ст,2ст,1ст

            ///1. Четем какво ресто трябва да върнем и го превръщаме в стотинки 
            double changeToReturn = double.Parse(Console.ReadLine())*100;
            /// създаваме брояч на монетите които връщме
            int count = 0;

            ///2. създаваме цикъл  който да се изпълнява докато не върнем цялото ресто
            /// като всеки път ще търсим най голямата монета и ще вадим стойноста и от 
            /// рестото и ще увеличваме броячът на монети с 1
            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                }
                else if (changeToReturn >=1)
                {
                    changeToReturn -= 1;
                }
                else
                {
                    changeToReturn = 0;
                    break;
                }
                count++;
            }


            //3. ще отпечатаме броят монети който сме върнали
            Console.WriteLine(count);
        }
    }
}
