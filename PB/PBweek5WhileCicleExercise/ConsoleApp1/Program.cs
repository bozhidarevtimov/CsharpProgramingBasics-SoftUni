using System;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ани отива до родния си град след много дълъг период извън страната. 
            ///Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга.
            ///
            ///Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея книга(текст). 
            ///Докато Ани не намери любимата си книга или не провери всички в библиотеката, 
            ///програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст).
            ///Книгите в библиотеката са свършили щом получите текст "No More Books".
            ///

            string bookName = Console.ReadLine();
            string searchedBook = "";
            int searchCount = 0;

            while (searchedBook != "No More Books")
            {
                searchedBook = Console.ReadLine();
                searchCount++;
                if (bookName == searchedBook)
                {
                    Console.WriteLine($"You checked {searchCount-1} books and found it.");
                    break;
                }
            }

            if (searchedBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {searchCount-1} books.");
            }



//•	Ако не открие търсената книгата да се отпечата на два реда:
//            o   "The book you search is not here!"
//o   "You checked {брой} books."
//•	Ако открие книгата си се отпечатва един ред:
//o   "You checked {брой} books and found it."



        }
    }
}
