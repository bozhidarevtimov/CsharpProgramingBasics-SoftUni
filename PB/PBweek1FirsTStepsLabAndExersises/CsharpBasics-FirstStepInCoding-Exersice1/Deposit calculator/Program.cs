using System;

namespace Deposit_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositsum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            //the percentage is divided by 100 because the console takes whole number
            //5.7, so we divide to get 0.57.
            double yearlypercentage = double.Parse(Console.ReadLine())/100;

            double sumaftertime = depositsum + time * ((depositsum*yearlypercentage)/12);
            Console.WriteLine(sumaftertime);



        }
    }
}
