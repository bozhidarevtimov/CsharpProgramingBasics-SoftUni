using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
 //  Студент трябва да отиде на изпит в определен час(например в 9:30 часа).
 //  Той идва в изпитната зала в даден час на пристигане(например 9:40).
 //  Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
 //  Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е дошъл след часа на изпита, той е закъснял.
 //  Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е
 //  дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.


            //Вход
            //От конзолата се четат 4 цели числа(по едно на ред), въведени от потребителя:
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            int hExamBegin = int.Parse(Console.ReadLine());
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            int mExamBegin = int.Parse(Console.ReadLine());
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            int hCome = int.Parse(Console.ReadLine());
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int mCome = int.Parse(Console.ReadLine());


            //Преубразуваме часовете и минутите на началото на изпита и пристигането В МИНУТИ.
            mExamBegin = mExamBegin + hExamBegin * 60;
            mCome = mCome + hCome * 60;
            //Намираме дали е закъснял или е навреме като намерим разликата
            int difference = mExamBegin - mCome;
            if (difference<0)
            {
                //late
                if (difference > -60)
                {
                    Console.WriteLine($"late {Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"late {Math.Abs(difference/60)} {Math.Abs(difference % 60):D2} hours after the start");
                    
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                if (difference == 0)
                {
                    Console.WriteLine($"On time {Math.Abs(difference)}");
                }
                else
                {
                    Console.WriteLine($"On time {Math.Abs(difference)} minutes before the start");
                }
                    //ontime
            }
            else 
            {
                if (difference < 60)
                {
                    Console.WriteLine($"early {Math.Abs(difference)} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"early {Math.Abs(difference / 60)} {Math.Abs(difference % 60):D2} hours before the start");

                }


                //early
            }






            //Изход
            //На първият ред отпечатайте:
            //•	“Late”, ако студентът пристига по-късно от часа на изпита.
            //•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            //•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            //•	
            //“mm minutes after the start” за закъснение под час.
     //•	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри,
            //например “1:03”.

        }
    }
}
