using System;

namespace radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double dgrees = radians * 180 / Math.PI;
            Console.WriteLine(dgrees);
        }
    }
}
