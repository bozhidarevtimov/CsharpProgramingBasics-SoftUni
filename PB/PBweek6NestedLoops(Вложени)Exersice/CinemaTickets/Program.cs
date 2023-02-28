using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, която да изчислява процента на билетите за
            //всеки тип от продадените билети:
            //студентски(student), стандартен(standard) и детски(kid),за всички прожекции.
            //Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
            //Вход
            //Входът е поредица от цели числа и текст:
            //•	На първия ред до получаване на командата "Finish" - име на филма – текст
            //•	На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
            //•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
            //o Типа на закупения билет - текст("student", "standard", "kid")
            //Изход
            //На конзолата трябва да се печатат следните редове:
            //•	След всеки филм да се отпечата, колко процента от кино залата е пълна
            //"{името на филма} - {процент запълненост на залата}% full."
            //•	При получаване на командата "Finish" да се отпечатат четири реда:
            //            o   "Total tickets: {общият брой закупени билети за всички филми}"
            //o   "{процент на студентските билети}% student tickets."
            //o   "{процент на стандартните билети}% standard tickets."
            //o   "{процент на детските билети}% kids tickets."

            
            //1. променливи
            //вход който да ползваме за име на филма или команда finish
            string movieName = Console.ReadLine();
            //вход за свободни места int
            int freeSeats = int.Parse(Console.ReadLine());
            //тип на билета текст който ще се чете за всеки филм по един път за всеки ред
            //до изчерпване на свободните места в залата или до получаване на командата "End":
            string ticketType= Console.ReadLine();
            //брояч на заетите места
            int takenSeat = 0;
            //броячи за типа на билетите
            int studentCount = 0;
            int standartCount = 0;
            int kidsCount = 0;
            int allTickets = 0;


            //2. While цикъл за всеки филм до пулачаване на командата finish
            while (movieName != "Finish")
            {   //добавяме 1 към заетите места  за да позлваме колко места са заети за изчесленията после
                ////добавям го тук тъй като веднага след входа а име на филма добавяме и билет(заето място)
                ///добавям го също и за секи цикъл на for цикъла
                /////МАХНИ ГО ОТ ТУК ИЛИ ПО СКОРО ТРЯБВА ДА СЕ НУЛИРА ЗАЩОТО ГО ИЗПОЗЛВАМЕ ЗА ДАДЕН ФИЛМ
                takenSeat=0;
                //в който ще друг цикъл който ще се върти до изчерпване на свободните места или команда Еnd
                ///ТУК МОЖЕ БИ ТРЯБВА ДА Е FOR ЦИКЪЛ С ОТДЕЛНА ПРОВЕРКА ВЪТРЕ ЗА КОМАНДАТА END ПРИ ЗАПИСВАНЕТО НА ТИПА БИЛЕТ
                for (int i = 1; i <=freeSeats ; i++)
                {
                    //в вторият цикъл за всяко място ще се чете тип на билета
                    //проверяваме и дали не сме получили командата End при въвеждане на типа билет
                    if (ticketType != "End")
                    {


                        //Проверяваме какъв тип е билета и добавяме в броячите за билетите
                        //Ще го направим с swicth case
                        switch (ticketType)
                        {
                            case "student":
                                studentCount++;
                                break;
                            case "standard":
                                standartCount++;
                                break;
                            case "kid":
                                kidsCount++;
                                break;
                        }
                        //добавяме 1 към заетите места  за да позлваме колко места са заети за изчесленията после                       
                        takenSeat=i;
                        //Четем отново тип билет aко for цикъла не се е завъртял толкова пъти колкото са свободните места.
                        if (i != freeSeats)
                        {
                            ticketType = Console.ReadLine();
                        }

                    }
                    else 
                    {
                        break;
                    }

                }                    
                double full = ((double)takenSeat/(double)freeSeats)* 100;
                //3. •	След всеки филм да се отпечата, колко процента от кино залата е пълна
                //"{името на филма} - {процент запълненост на залата}% full."
                Console.WriteLine($"{movieName} - {full:f2}% full.");

                //четем нов филм от конзолата
                movieName = Console.ReadLine();
                if (movieName != "Finish")
                {
                    //четем отново свободни места
                    freeSeats = int.Parse(Console.ReadLine());
                    //Четем отново тип билет
                    ticketType = Console.ReadLine();
                }
                else 
                {
                    break;
                }

            }
            //добавяме всички билети от филмите към общ брой билети от всички филми
            allTickets += studentCount + standartCount + kidsCount;

            //4. //•	При получаване на командата "Finish" да се отпечатат четири реда:
            //            o   "Total tickets: {общият брой закупени билети за всички филми}"
            //o   "{процент на студентските билети}% student tickets."
            //o   "{процент на стандартните билети}% standard tickets."
            //o   "{процент на детските билети}% kids tickets."
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{((double)studentCount/(double)allTickets)*100:f2}% student tickets.");
            Console.WriteLine($"{((double)standartCount / (double)allTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{((double)kidsCount / (double)allTickets) * 100:f2}% kids tickets.");


        }
    }
}
