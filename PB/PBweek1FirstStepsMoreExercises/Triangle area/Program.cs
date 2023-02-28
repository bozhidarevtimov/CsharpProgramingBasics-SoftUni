using System;

namespace Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата страна и височина на триъгълник 
            // и пресмята неговото лице. Използвайте формулата за лице на триъгълник: 
            //area = a * h / 2.Форматирате изхода до втория знак след десетичната запетая.

            //чете от конзолата страна и височина на триъгълник
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // пресмята неговото лице.Използвайте формулата за лице на триъгълник: 
            //area = a * h / 2.
            double area = (a*h)/2;



            //.Форматирате изхода до втория знак след десетичната запетая.
            Console.WriteLine(area.ToString("0.00"));
        }
    }
}
