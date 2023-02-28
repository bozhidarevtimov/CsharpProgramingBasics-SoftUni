using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поканени сте на 30 - ти рожден ден, на който рожденикът черпи с огромна торта.
            //Той обаче не знае колко парчета могат да си вземат гостите от нея.Вашата задача е да напишете програма,
            //която изчислява броя на парчетата, които гостите са взели, преди тя да свърши.
            //Ще получите размерите на тортата(широчина и дължина – цели числа в интервала[1...1000])
            //и след това на всеки ред, до получаване на командата "STOP" или докато не свърши тортата,
            //броят на парчетата, които гостите вземат от нея.
            //Бележка: Едно парче торта е с размер 1х1 см.
            //Да се отпечата на конзолата един от следните редове:
            //•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            //•	"No more cake left! You need {брой недостигащи парчета} pieces more."

            //1. Четем размерите на тортата (широчина и дължина – цели числа в интервала[1...1000])
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            // Торта обща големина
            int cakeSize = width * lenght;
            //Бележка: Едно парче торта е с размер 1х1 см.
            int allPeaces = width * lenght;
            //2.правим променлива за input за парчетата торта които гостите взимат
            string input = Console.ReadLine();
            //променлива и за броят на общо взетите парчета.
            int peacesTaken = 0;


            //3. цикъл при който всеки път се чете брой парчета които гостите взимат докато не се напише командата Stop

            while (input != "STOP")
            {
                peacesTaken += int.Parse(input);
                //проверява се спрямо размера на тортата дали има останали парчета
                if (peacesTaken>allPeaces)
                {
                    //ако сса свършили.
                    //•	"No more cake left! You need {брой недостигащи парчета} pieces more."
                    Console.WriteLine($"No more cake left! You need {peacesTaken - allPeaces} pieces more.");
                    break;
                }
                input = Console.ReadLine();

            }
            //Да се отпечата на конзолата един от следните редове:
            //•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            if (input == "STOP") 
            {
                Console.WriteLine($"{allPeaces-peacesTaken} pieces are left.");
            }

            
        }
    }
}
