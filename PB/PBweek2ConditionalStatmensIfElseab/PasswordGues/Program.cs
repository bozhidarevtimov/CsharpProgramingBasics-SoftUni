﻿using System;

namespace PasswordGues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете парола(текст),
            //въведена от потребителя и проверява дали въведената
            //парола съвпада с фразата "s3cr3t!P@ssw0rd".
            //При съвпадение да се изведе "Welcome".При несъвпадение да се изведе "Wrong password!".

            //чете парола(текст)
            string pass = Console.ReadLine();

            //проверява дали въведената
            //парола съвпада с фразата "s3cr3t!P@ssw0rd"

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
