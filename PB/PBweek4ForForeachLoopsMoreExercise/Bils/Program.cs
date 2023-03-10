using System;

namespace Bils
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма която да пресмята средният разход за месец на семейство за даден период време.

            //За всеки месец разходите са следните:
            //•	За ток – всеки месец е различен, ще се чете от конзолата
            //•	за вода – 20 лв.
            //•	за интернет – 15 лв.
            //•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20 %.

            //За всеки разход трябва да се пресметне колко общо е платено за всички месеци.

            //Вход
            //Входът се чете от конзолата:
            //•	Първи ред – месеците за които се търси средният разход – цяло число в интервала[1...100]
            //•	За всеки месец – сметката за ток – реално число в интервала[1.00...1000.00]

            //Изход
            //Да се отпечата на конзолата 5 реда:
            //•	1ви ред: "Electricity: {ток за всички месеци} lv"
            //•	2ри ред: "Water: {вода за всички месеци} lv"
            //•	3ти ред: "Internet: {интернет за всички месеци} lv"
            //•	4ти ред: "Other: {други за всички месеци} lv"
            //•	5ти ред: "Average: {средно всички разходи за месец} lv"
            //Всички числа трябва да са форматирана до вторият знак след запетаята.

            //1.Четем от конзолата месеците за които ще търсим среден разход
            int months = int.Parse(Console.ReadLine());

            //променливи  за общ сбор на отделните сметки
            double water = 0;
            double internet = 0;
            double other = 0;
            double electricity = 0;


            //2.Четем За всеки месец – сметката за ток – реално число в интервала[1.00...1000.00]
            //правим си променлива която ще четем в цикъл за всеки месец
            double electricityMonth = 0;

            for (int i = 0; i < months; i++)
            {
                //правим променлива за сбора на сметките за месеца преди да добавим 20% за да я ползваме за други разходи
                double allBills = 0;
                //За всеки разход трябва да се пресметне колко общо е платено за всички месеци.
                // затова ще добавяме към променливите за сбор на отделните сметки

               // За ток – всеки месец е различен, ще се чете от конзолата
            //•	за вода – 20 лв.
            //•	за интернет – 15 лв.
            //•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20 %.
                electricityMonth = double.Parse(Console.ReadLine());
                electricity += electricityMonth;
                water += 20;
                internet += 15;
                allBills = electricityMonth + 20 + 15;
                other += allBills + allBills * 0.20;

            }

            //пресмята средният разход за месец на семейство за даден период време.
            double allAvarage = (electricity + water + internet + other) / months;
            //За всеки разход трябва да се пресметне колко общо е платено за всички месеци.

            //•	1ви ред: "Electricity: {ток за всички месеци} lv"
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            //•	2ри ред: "Water: {вода за всички месеци} lv"
            Console.WriteLine($"Water: {water:f2} lv");
            //•	3ти ред: "Internet: {интернет за всички месеци} lv"
            Console.WriteLine($"Internet: {internet:f2} lv");
            //•	4ти ред: "Other: {други за всички месеци} lv"
            Console.WriteLine($"Other: {other:f2} lv");
            //•	5ти ред: "Average: {средно всички разходи за месец} lv"
            Console.WriteLine($"Average: {allAvarage:f2} lv");
            //Всички числа трябва да са форматирана до вторият знак след запетаята.
        }
    }
}
