using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.
            //Има три вида прожекции с билети на различни цени:
            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            //Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа),
            //въведени от потребителя, и изчислява общите приходи от билети при пълна зала.
            //Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  


            //1. тип прожекция, брой редове и колони
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //2. пресмятаме свободни места в залата r*c
            int freeSpaces = r * c;
            // променлива за income
            double income = 0;

            //3.проверка на типа прожекция с SwitchCase            
            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            //switch (type) 
            //{
            //    case "Premiere":
            //        income = freeSpaces * 12.00;
            //        break;
            //    case "Normal":
            //        income = freeSpaces * 7.50;
            //        break;
            //    case "Discount":
            //        income = freeSpaces * 5.00;
            //        break;

            //}
            //Console.WriteLine("{0:f2} leva", income);

            //3.проверка на типа прожекция с IfElse

            if (type == "Premiere")
            {
                income = freeSpaces * 12.00;
            }
            else if (type=="Normal")
            {
                income = freeSpaces * 7.50;
            }
            else if (type=="Discount")
            {
                income = freeSpaces * 5.00;
            }

            Console.WriteLine("{0:f2} leva", income);







        }
    }
}
