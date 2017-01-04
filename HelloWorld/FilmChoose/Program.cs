using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmChoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            String name = Console.ReadLine();
            
            Console.WriteLine("Здравствуйте, " + name + ". Давайте выберем фильм на вечер.");
            Console.WriteLine("Какой жанр фильма Вы предпочитаете, комедия или драмма?");
            String genre = Console.ReadLine();

            if (genre == "комедия")
            {
                Console.WriteLine("1 - Час пик");
                Console.WriteLine("2 - Плохие парни");
                Console.WriteLine("3 - Вышибала");
            } else
            {
                Console.WriteLine("1 - Побег из Шоушенка");
                Console.WriteLine("2 - Вечное сияние чистоо разума");
            }
            Console.ReadLine();
        }
    }
}
