using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере
            //  необходимата сума. Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от
            //  наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.

            //Вход
            //От конзолата се четат:
            //•	Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            //•	Налични пари -реално число в интервала[0.00...25000.00]
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            //След това многократно се четат по два реда:
            //•	Вид действие – текст с възможности "spend" и "save"
            //•	Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]
            string activity;
            double activityMoney;
            ///Променливи за брой последователни дни които е пестила, общ брой дни, общо спестени пари
            int sequanceSpendDays = 0;
            int allDays = 0;


            //След това многократно се четат по два реда:
            //•	Вид действие – текст с възможности "spend" и "save"
            //•	Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]

            while (moneyAvailable<moneyNeeded)
            {

                activity = Console.ReadLine();
                activityMoney = double.Parse(Console.ReadLine());

                allDays++;
                if (activity == "save")
                {
                    moneyAvailable += activityMoney;
                    sequanceSpendDays = 0;
                }
                else
                {
                    sequanceSpendDays++;
                    if (sequanceSpendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{allDays}");
                        break;
                    }
                    moneyAvailable -= activityMoney;
                    if (moneyAvailable<0)
                    {

                        moneyAvailable = 0;
                    }
                   
                }



            }

            if (moneyAvailable >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {allDays} days.");
            }

            //Изход
            //Програмата трябва да приключи при следните случаи:
            //•	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            //            o   "You can't save the money."
            //o   "{Общ брой изминали дни}"
            //•	Ако Джеси събере парите за почивката на конзолата се изписва:
            //o   "You saved the money for {общ брой изминали дни} days."

        }
    }
}
