using System;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Басейн с обем V има две тръби от които се пълни.
            //Всяка тръба има определен дебит (литрите вода минаващи през една тръба за един час).
            //Работникът пуска тръбите едновременно и излиза за N часа.
            //Напишете програма, която изкарва състоянието на басейна, в момента, когато работникът се върне. 

            //Вход
            //От конзолата се четат четири реда:
            //•	Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала[1…10000].
            double v = double.Parse(Console.ReadLine());
            //•	Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].
            double p1 = double.Parse(Console.ReadLine());
            //•	Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала[1…5000].
            double p2 = double.Parse(Console.ReadLine());
            //•	Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала[1.0…24.00]
            double hours = double.Parse(Console.ReadLine());

            //Напишете програма, която изкарва състоянието на басейна, в момента, когато работникът се върне.
            //запълване от тръба 1 и 2
            double pipe1Contribution = p1*hours;
            double pipe2Contribution = p2 * hours;
            //запълненост на басейна общо и в проценти
            double full = pipe1Contribution + pipe2Contribution;
            double fullPercentage = full / v * 100; 
            //Проценти от 1ва и 2ра тръба
            double p1Percentage = pipe1Contribution / full * 100;
            double p2Percentage = pipe2Contribution / full * 100;


            //Изход
            //  Да се отпечата на конзолата едно от двете възможни състояния:
            //•	До колко се е запълнил басейна и коя тръба с колко процента е допринесла.
            //o   "The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."
            if (full<=v)
            {
                Console.WriteLine($"The pool is {fullPercentage:f2}% full. Pipe 1: {p1Percentage:f2}%. Pipe 2: {p2Percentage:f2}%.");
            }
            //Aко басейнът се е препълнил – с колко литра е прелял за даденото време.
            //o   "For {часовете, които тръбите са пълнили вода} hours the pool overflows with {литрите вода в повече} liters."
            else
            {
                double overflow = full - v;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }
            


        }
    }
}
