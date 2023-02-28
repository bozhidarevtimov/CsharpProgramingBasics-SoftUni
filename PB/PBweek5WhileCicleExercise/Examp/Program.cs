using System;

namespace Examp
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough"
            //            от лектора си.При всяка решена задача той получава оценка.
            //            Програмата трябва да приключи прочитането на данни при команда "Enough"
            //            или ако Марин получи определения брой незадоволителни оценки.
            //Незадоволителна е всяка оценка, която е по-малка или равна на 4.


            //Вход
            //•	На първи ред - брой позволени незадоволителни оценки -цяло число в интервала[1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача -текст(низ)
            //o Оценка -цяло число в интервала[2…6]

            int lowGradesAllowed = int.Parse(Console.ReadLine());


            double gradeTotall = 0;
            int taskCount = 0;
            int lowGrades = 0;
            string lastTask = "";

            string task = Console.ReadLine();
            while (task != "Enough") 
            {
                    lastTask = task;
                    int taskGrade = int.Parse(Console.ReadLine());
                    gradeTotall += taskGrade;
                    taskCount++;

                    if (taskGrade <= 4)
                    {
                   
                        lowGrades++;

                        if (lowGrades==lowGradesAllowed)
                        {
                        Console.WriteLine($"You need a break, {lowGrades} poor grades.");
                        break;
                        }

                    }
                task = Console.ReadLine();


            }

            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {gradeTotall/(taskCount):f2}");
                Console.WriteLine($"Number of problems: {taskCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

            

//Изход
//•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
//            o   "Average score: {средна оценка}"
//o   "Number of problems: {броя на всички задачи}"
//o   "Last problem: {името на последната задача}"
//•	Ако получи определеният брой незадоволителни оценки:
//o   "You need a break, {брой незадоволителни оценки} poor grades."
//Средната оценка да бъде форматирана до втория знак след десетичната запетая.

        }
    }
}
