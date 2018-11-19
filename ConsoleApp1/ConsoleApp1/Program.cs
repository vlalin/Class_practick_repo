using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<vlalin> Municipality = new List<vlalin>();

            Municipality.Add(new vlalin("vlad", "Linskiy", "Dmitievish", 21));
            Municipality.Add(new vlalin("Vova", "Lavrov", "Goose", 21));
            Municipality.Add(new vlalin("Ruslan", "Fateev", "Viktoovich", 21));
            Municipality.Add(new vlalin("Misha", "Kolygin", "Kolygin", 21));

            Municipality.ForEach( x => x.info());

            print_count_of_piople(Municipality);

            Console.Read();
        }

        static void print_count_of_piople(List<vlalin> vlalins)
        {
            Console.WriteLine("Количество людей = " + vlalins.Count.ToString());
        }
    }
}
