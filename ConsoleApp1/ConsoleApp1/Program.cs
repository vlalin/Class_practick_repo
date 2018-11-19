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

            add_piople(Municipality);
            add_piople(Municipality);
            

            Municipality.ForEach( x => x.info());
            print_count_of_piople(Municipality);

            

            Console.Read();
        }

        static void print_count_of_piople(List<vlalin> vlalins)
        {
            Console.WriteLine("Количество людей = " + vlalins.Count.ToString());
        }

        static void add_piople(List<vlalin> vlalins)
        {
            string name = String.Empty;
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            string surname = String.Empty;
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();

            string lastname = String.Empty;
            Console.Write("Введите отчество: ");
            lastname = Console.ReadLine();

            int age = 0;
            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.Clear();

            vlalins.Add(new vlalin(name, surname, lastname, age));
        }
    }
}
