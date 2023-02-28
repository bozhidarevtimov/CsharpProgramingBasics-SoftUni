using System;

namespace areaRadiusCercle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата число r
            //и пресмята и отпечатва лицето и периметъра на кръг
            // окръжност с радиус r, като форматирате изхода в следния вид: "<calculated area>"
            //"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.


            //чете от конзолата число r
            double r = double.Parse(Console.ReadLine());

            //пресмята и отпечатва лицето и периметъра на кръг
            // окръжност с радиус r

            double area = Math.PI * r * r;
            double radius = 2 * Math.PI * r;

            //изхода в следния вид: "<calculated area>"
            //"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.
            Console.WriteLine(area.ToString("0.00"));
            Console.WriteLine(radius.ToString("0.00"));


        }
    }
}
