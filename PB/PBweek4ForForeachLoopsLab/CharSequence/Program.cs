using System;
using System.Linq;

namespace CharSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете текст (стринг), въведен от потребителя и печата всеки символ от
            //текста на отделен ред.

            string text = Console.ReadLine();

                for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
