using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {

//            Hапишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
//•	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
//•	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".


            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string enterPass = Console.ReadLine();

            while (enterPass != password) 
            {
                enterPass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
