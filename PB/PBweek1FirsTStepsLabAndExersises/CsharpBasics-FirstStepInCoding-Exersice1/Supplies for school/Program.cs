using System;

namespace Supplies_for_school
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double dissercent = double.Parse(Console.ReadLine())/100;

            double totall = (pens*5.80+ markers*7.20 + preparat*1.20);
            double totallwithdiss = totall - totall * dissercent;

            Console.WriteLine(totallwithdiss);


        }
    }
}
