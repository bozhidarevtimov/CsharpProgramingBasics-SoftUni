using System;

namespace P02.Num1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            double qunatity = double.Parse(Console.ReadLine());
            double tottal = qunatity * 7.61;
            double discount = 0.18;
            double totalld = tottal * discount;
            double totalwothd = tottal * 0.82;
            Console.WriteLine($"The final price is: {totalwothd} lv");
            Console.WriteLine($"The discount is: {totalld} lv");


        }
    }
}
