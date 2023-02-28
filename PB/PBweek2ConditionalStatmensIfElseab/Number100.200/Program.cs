using System;

namespace Number100._200
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете цяло число, въведено от потребителя
            //и проверява дали е под 100, между 100 и 200 или над 200. Ако числото е:
            //•	под 100 отпечатайте: "Less than 100"
            //•	между 100 и 200 отпечатайте: "Between 100 and 200"
            //•	над 200 отпечатайте: "Greater than 200"

            //чете цяло число,
            int a = int.Parse(Console.ReadLine());

            //проверява дали е под 100, между 100 и 200 или над 200.

            
                if (a <= 99)
                {
                    Console.WriteLine("Less than 100");

                }
                else if (a >= 100 & a <= 200)
                {
                    Console.WriteLine("Between 100 and 200");
                }
                else
                    Console.WriteLine("Greater than 200");


                    
        }
    }
}
