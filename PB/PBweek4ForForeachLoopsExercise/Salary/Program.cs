using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шеф на компания забелязва че все повече служители прекарват време в сайтове, които ги разсейват.  
            //За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си.
            //Според отворения сайт в таба се налагат следните глоби:
            //•	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.


            //От конзолата се четат два реда:
            //•	Брой отворени табове в браузъра n -цяло число в интервала[1...10]
            //•	Заплата - число в интервала[500...1500]
            //След това n – на брой пъти се чете име на уебсайт – текст
            int openTabs = int.Parse(Console.ReadLine());
            int salary  = int.Parse(Console.ReadLine());
            string siteName;

            for (int i = 0; i <= openTabs ; i++)
            {
                siteName = Console.ReadLine();
                if (siteName == "Facebook")
                {
                    salary -= 150;
                }
                else if (siteName == "Instagram")
                {
                    salary -= 100;
                }
                else if (siteName == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    //•	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва
                    //"You have lost your salary." и програмата приключва.
                    Console.WriteLine("You have lost your salary.");
                        //brake е излолзвано както в switches  така и в цикли за да прекъсне цикъла
                    break;
                }
            }


            //•	В противен случай след проверката на конзолата се изписва остатъкът от заплатата(да се изпише като цяло число).
            if (salary > 0){

                Console.WriteLine(salary);
            }
        }
    }
}
