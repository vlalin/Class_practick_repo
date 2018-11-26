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

            add_people_by_user_count(Municipality);
            print_count_of_piople(Municipality);
            Municipality.ForEach(x => Console.WriteLine( x.ToString()) );

            //ваводим 32 черточки
            Console.WriteLine(new String('-', 32));
            //вызываем конструктор копирования (который создаст новго человека скопировав всю инфу с последнего в списке)
            vlalin tmp = new vlalin(Municipality.Last());
            Console.WriteLine(tmp.ToString());

            Console.Read();
        }

        static void print_count_of_piople(List<vlalin> vlalins)
        {
            Console.WriteLine("Количество людей = " + vlalins.Count.ToString());
        }

        static void add_piople(List<vlalin> vlalins)
        {
            
            string name = String.Empty;
            name = check_param("Введите имя: "); ;

            string surname = String.Empty;
            surname = check_param("Введите фамилию: ");

            string lastname = String.Empty;
            lastname = check_param("Введите отчество: ");

            int age = 0;
            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.Clear();

            vlalins.Add(new vlalin(name, surname, lastname, age));
        }

        static string check_param(string parametr_name)
        {
            bool isNormalStr = true;
            do
            {
                Console.Clear();
                isNormalStr = true;
                Console.Write(parametr_name);
                string input = Console.ReadLine();
                if (input != String.Empty)
                {
                    foreach (var item in input)
                    {
                        if (Char.IsDigit(item))
                        {
                            isNormalStr = false;
                            break;
                        }
                    }

                }
                else
                    isNormalStr = false;
                if(isNormalStr == true)
                    return input;
            } while (true);
        }

        static void add_people_by_user_count(List<vlalin> vlalins)
        {
            int value = 0;
            Console.Write("какое количество людей Вы хотите добавить: ");
            Int32.TryParse(Console.ReadLine(), out value);


            for (int i = 0; i < value; i++)
            {
                add_piople(vlalins);
            }
        }
    }
}
