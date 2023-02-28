using System;

namespace CinemaTicket_AndORNotOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
            //Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
            // 12      12      14         14        12      16         16

            string day = Console.ReadLine();
            //ако деня е понеделник ИЛИ || вторник ИЛИ || петък
            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                Console.WriteLine(12);

            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                Console.WriteLine(14);

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine(16);

            }

        }
    }
}
