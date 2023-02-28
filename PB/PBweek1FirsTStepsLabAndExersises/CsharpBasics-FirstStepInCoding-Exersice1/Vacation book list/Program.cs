using System;

namespace Vacation_book_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesperhour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalltime = pages / pagesperhour;
            int timeperday = totalltime / days;

            Console.WriteLine(timeperday);
        }
    }
}
