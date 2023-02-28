using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Марина обича да пътува. Тя има 3 домашни любимеца (куче, котка и костенурка).
            //Когато заминава на пътешествие трябва да съобрази колко храна да им остави, за да не останат гладни.
            //Напишете програма, която пресмята колко килограма храна ще изядат всички за времето,
            //в което Марина отсъства и дали оставената храна от нея ще им е достатъчна.
            //Всяко животно изяжда определено количество храна на ден.

            //Вход
            //  От конзолата се четат пет реда:
            //•	Първи ред – брой дни – цяло число в интервал[1…5000]
            double tripDays = double.Parse(Console.ReadLine());
            //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            double foodLeaved = double.Parse(Console.ReadLine());
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            double dogFoodForDayKg = double.Parse(Console.ReadLine());
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            double catFoodForDayKg = double.Parse(Console.ReadLine());
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]
            double turtleFoodForDayGr = double.Parse(Console.ReadLine());

            //пресмятаме колко яде всяко животно на ден и ги прибавяме
            double allEatenFood = dogFoodForDayKg * tripDays + catFoodForDayKg * tripDays + (turtleFoodForDayGr/1000) * tripDays;


            //Изход
            //На конзолата трябва да се отпечата на един ред:
            //•	Ако оставената храна Е достатъчна:
            //            o   "{килограма остатък} kilos of food left."
            //	Резултатът трябва да е закръглен към по - ниското цяло число
            if (foodLeaved >= allEatenFood)
            {
                Console.WriteLine($"{Math.Floor(foodLeaved - allEatenFood)} kilos of food left.");
            }
            //•	Ако оставената храна НЕ Е достатъчна:
            //o   “{ килограма недостигат} more kilos of food are needed.”
            //	Резултатът трябва да е закръглен към по - високото цяло число
            else 
            {
                Console.WriteLine($"{Math.Ceiling(allEatenFood-foodLeaved)} more kilos of food are needed.");
            }




        }
    }
}
