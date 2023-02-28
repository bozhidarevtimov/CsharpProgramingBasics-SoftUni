using System;

namespace FitnesCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали първоначално налична сума е достатъчна,
            //за да се заплати карта за месечен достъп във фитнес.

            //Цената на картата зависи от пола на клиента и спорта, който практикува:
            //Пол       Gym    Boxing   Yoga    Zumba   Dances  Pilates
            //мъж	    $42      $41     $45     $34     $51       $39
            //жена      $35      $37     $42     $31     $53       $37

            //Всички цени на карти за ученици(възраст под 19 години вкл.) са с 20 % намаление.


            //Вход
            //От конзолата се прочитат 4 реда:
            //•	Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            //•	Пол - символ('m' за мъж и 'f' за жена)
            //•	Възраст - цяло число в интервала[5…105]
            //•	Спорт - текст(една от възможностите в таблицата)

            //Изход
            //На конзолата се отпечатва 1 ред:
            //•	Ако сумата е достатъчна:
            //"You purchased a 1 month pass for {sport}."
            //където { sport}
            //            е въведения тип спорт
            //•	Ако сумата не е достатъчна трябва да се пресметне колко още пари са необходими, за да се закупи карта:
            //"You don't have enough money! You need ${money} more."
            //където { money}
            //            e оставащата сума нужна, за да се закупи картата, форматирана до втория знак след десетичната запетая.


            //1.Четем
            //•	Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            double budjet = double.Parse(Console.ReadLine());
            //•	Пол - символ('m' за мъж и 'f' за жена)
            char sex = char.Parse(Console.ReadLine());
            //•	Възраст - цяло число в интервала[5…105]
            int age = int.Parse(Console.ReadLine());
            //•	Спорт - текст(една от възможностите в таблицата)
            string sport = Console.ReadLine();

            //променливи
            //цена на карта
            double cardPrice = 0;


            //2. проверяваме за пола, възраста и спорта и според тях определяме цената на картата
            //Цената на картата зависи от пола на клиента и спорта, който практикува:
            //Пол       Gym    Boxing   Yoga    Zumba   Dances  Pilates
            //мъж	    $42      $41     $45     $34     $51       $39
            //жена      $35      $37     $42     $31     $53       $37

            //Всички цени на карти за ученици(възраст под 19 години вкл.) са с 20 % намаление.

            //ще започнем от годините и пола с if проверки а за спорта ще направим switch case
            if (age <= 19)
            {
                if (sex == 'm')
                {
                    switch (sport)
                    {
                        case "Gym":
                            cardPrice = 42 - (42 * 0.20);
                            break;
                        case "Boxing":
                            cardPrice = 41 - (41 * 0.20);
                            break;
                        case "Yoga":
                            cardPrice = 45 - (45 * 0.20);
                            break;
                        case "Zumba":
                            cardPrice = 34 - (34 * 0.20);
                            break;
                        case "Dances":
                            cardPrice = 51 - (51 * 0.20);
                            break;
                        case "Pilates":
                            cardPrice = 39 - (39 * 0.20);
                            break;

                    }

                }
                else
                {
                    switch (sport)
                    {//жена      $35      $37     $42     $31     $53       $37
                        case "Gym":
                            cardPrice = 35 - (35 * 0.20);
                            break;
                        case "Boxing":
                            cardPrice = 37 - (37 * 0.20);
                            break;
                        case "Yoga":
                            cardPrice = 42 - (42 * 0.20);
                            break;
                        case "Zumba":
                            cardPrice = 31 - (31 * 0.20);
                            break;
                        case "Dances":
                            cardPrice = 53 - (53 * 0.20);
                            break;
                        case "Pilates":
                            cardPrice = 37 - (37 * 0.20);
                            break;

                    }
                }
            }

            else 
            {
                if (sex == 'm')
                {
                    switch (sport)
                    {
                        case "Gym":
                            cardPrice = 42;
                            break;
                        case "Boxing":
                            cardPrice = 41;
                            break;
                        case "Yoga":
                            cardPrice = 45;
                            break;
                        case "Zumba":
                            cardPrice = 34;
                            break;
                        case "Dances":
                            cardPrice = 51;
                            break;
                        case "Pilates":
                            cardPrice = 39;
                            break;

                    }

                }
                else
                {
                    switch (sport)
                    {//жена      $35      $37     $42     $31     $53       $37
                        case "Gym":
                            cardPrice = 35;
                            break;
                        case "Boxing":
                            cardPrice = 37;
                            break;
                        case "Yoga":
                            cardPrice = 42;
                            break;
                        case "Zumba":
                            cardPrice = 31;
                            break;
                        case "Dances":
                            cardPrice = 53;
                            break;
                        case "Pilates":
                            cardPrice = 37;
                            break;

                    }
                }
            }

            //•	Ако сумата е достатъчна:
            //"You purchased a 1 month pass for {sport}."
            //където { sport}
            //            е въведения тип спорт
            //•	Ако сумата не е достатъчна трябва да се пресметне колко още пари са необходими, за да се закупи карта:
            //"You don't have enough money! You need ${money} more."
            //където { money}
            //            e оставащата сума нужна, за да се закупи картата, форматирана до втория знак след десетичната запетая.
            if (budjet >= cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough money! You need ${cardPrice-budjet:f2} more.");
            }

        }
    }
}
