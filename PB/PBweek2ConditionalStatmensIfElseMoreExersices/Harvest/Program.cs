using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.
            //От 1 кв.м лозе се изкарват Y килограма грозде. За 1 литър вино са нужни 2,5 кг. грозде.
            //Желаното количество вино за продан е Z литра.
            //Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.
            //Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.

            // Вход
            //Входът се чете от конзолата и се състои от точно 4 реда:
            //•	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            double area = double.Parse(Console.ReadLine());
            //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            double grapePer1sqArea = double.Parse(Console.ReadLine());
            //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            double neededWineForSale = double.Parse(Console.ReadLine());
            //•	4ти ред: брой работници – цяло число в интервала[1 … 20]
            double workers = double.Parse(Console.ReadLine());

            // пресмятаме колко грозде ще се произведе
            double totallGrape = area * grapePer1sqArea;
            //пресмятаме 40% от реколтата, което ще отиде за вино 
            double grapeForWine = totallGrape * 0.40;
            //пресмятаме колко вино ще може да бъде произведено
            double wineLiters = grapeForWine / 2.5;




            //  Изход
            //На конзолата трябва да се отпечата следното:

            //•	Ако произведеното вино е по - малко от нужното:
            //o   “It will be a tough winter!More { недостигащо вино} liters wine needed.”
            //	Резултатът трябва да е закръглен към по - ниско цяло число
            if (wineLiters < neededWineForSale)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWineForSale - wineLiters)} liters wine needed.");
            }
            //•	Ако произведеното вино е колкото или повече от нужното:
            //            o   “Good harvest this year! Total wine: { общо вино} liters.”
            //	Резултатът трябва да е закръглен към по - ниско цяло число
            else if (wineLiters>=neededWineForSale)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                //o   “{ Оставащо вино} liters left -> { вино за 1 работник}  liters per person.”
                //	И двата резултата трябва да са закръглени към по - високото цяло число
                Console.WriteLine($"{Math.Ceiling(wineLiters-neededWineForSale)} liters left -> {Math.Ceiling((wineLiters - neededWineForSale)/workers)} liters per person.");

            }



        }
    }
}
