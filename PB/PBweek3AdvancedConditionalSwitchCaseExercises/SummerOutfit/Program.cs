using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лято е с много променливо време и Виктор има нужда от вашата помощ.
            //Напишете програма която спрямо времето от денонощието и градусите да препоръча на
            //Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня,
            //които изискват и различен външен вид, тях може да видите от таблицата.


            //От конзолата се четат точно два реда:

            //•	Градусите - цяло число в интервала[10…42]
            //•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            //Правим си променливи за outfit и обувки
            string outfit = "";
            string shoes = "";


            //Проверяваме колко градуса и какъв етап от деня е,
            //и пишем код спрямо таблицата в описанието на задачата
            if (degrees <= 18)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (partOfDay == "Afternoon" || partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }

            }
            else if (degrees <= 24)
            {
                if (partOfDay == "Morning" || partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                }
            }
            else 
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                }
                else if (partOfDay == "Afternoon") 
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");



            //Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."

        }
    }
}
