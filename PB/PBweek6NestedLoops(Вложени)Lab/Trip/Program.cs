using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ани обича да пътува и иска тази година да посети няколко различни дестинации.Като си избере дестинация,
            //ще прецени колко пари ще й трябват, за да отиде до там и ще започне да спестява.Когато е спестила достатъчно,
            //ще може да пътува.
            //От конзолата всеки път ще се четат първо дестинацията и минималния бюджет, който ще е нужен за пътуването.
            //След това ще се четат няколко суми, които Ани спестява като работи и когато успее да събере достатъчно за пътуването,
            //ще заминава, като на конзолата трябва да се изпише:
            // "Going to {дестинацията}!"
            //Когато е посетила всички дестинации, които иска, вместо дестинация ще въведе "End" и програмата ще приключи.

            //1. променливи.
            //-вход от конзолата
            string input = Console.ReadLine();
            //-дестинация
            string destination;
            //- бюджет 
            double budget = 0;

            //2. while цикъл който се изпълнява докато входът е различен от "End"
            while (input != "End")
            {
                //=> присвояваме на променливата дистинацията = входът от конзолата
                destination = input;
                //=“ четем необходим бюджет
                budget = double.Parse(Console.ReadLine());
                //=> създаваме вътрешен while цикъл който да се изпълнява докато не спести достатъчно
                while (budget>0)
                {

                    //=“ изваждаме от бюджета парите които спестява
                    budget -= double.Parse(Console.ReadLine());
                  
                }
                // = след като спести достатъчно отпечатваме "Going to {дестинацията}!"
                Console.WriteLine($"Going to {destination}!");

                //= четем нов вжод от конзолата
                input = Console.ReadLine();

            }


        }
    }
}
