using System;

namespace Basketball_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Джеси решава, че иска да се занимава с баскетбол, но за да тренира е нужна екипировка.
            //Напишете програма, която изчислява какви разходи ще има Джеси, ако започне да тренира,
            //като знаете колко е таксата за тренировки по баскетбол за период от 1 година.Нужна екипировка: 

            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година

            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете

            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип

            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка


            //Вход
            //От конзолата се четe 1 ред:
            //•	Годишната такса за тренировки по баскетбол – цяло число в интервала[0… 9999]
            double tax = double.Parse(Console.ReadLine());
            //-------------------------------------------
            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            double shoes = tax -tax * 0.4;

            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            double clothes = shoes - shoes * 0.2;

            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            double ball = clothes/4;

            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
            double accesories = ball / 5;


            //Изход
            //Да се отпечата на конзолата колко ще са разходите на Джеси, ако започне да спортува баскетбол.
            double sum = tax + shoes + clothes + ball + accesories;
            Console.WriteLine(sum);

        }
    }
}
