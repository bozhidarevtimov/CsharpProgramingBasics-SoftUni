using System;

namespace AreaOfFigurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, в която потребителят въвежда вида и размерите на геометрична
            //фигура и пресмята лицето й. Фигурите са четири вида: квадрат (square),
            //правоъгълник (rectangle), кръг (circle) и триъгълник (triangle).
            //На първия ред на входа се чете вида на фигурата (текст със следните възможности:
            //square, rectangle, circle или triangle). 

            //•	Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число
            //-дължина на страната му
            //•	Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа
            //-дължините на страните му
            //•	Ако фигурата е кръг(circle): на следващия ред чете едно дробно число
            //- радиусът на кръга
            //•	Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа
            //-дължината на страната му и дължината на височината към нея
            //Резултатът да се закръгли до 3 цифри след десетичната запетая. 


            //въвежда вида и размерите на геометрична фигура 
            double area;
            string figure = Console.ReadLine();

            //•	Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число
            //-дължина на страната му
            if (figure == "square")
            {
                double x = double.Parse(Console.ReadLine());
                area = x * x;
                Console.WriteLine($"{area:f3}");
            }
            //•	Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа
            //-дължините на страните му
            else if (figure == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                area = x*y;
                Console.WriteLine($"{area:f3}");

            }

            //•	Ако фигурата е кръг(circle): на следващия ред чете едно дробно число
            //- радиусът на кръга
            else if (figure=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI*r*r;
                Console.WriteLine($"{area:f3}");

            }
            //Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа
            //-дължината на страната му и дължината на височината към нея
            else if (figure == "triangle")
            {
                double x = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (x*h) / 2;
                Console.WriteLine($"{area:f3}");

            }




        }
    }
}
