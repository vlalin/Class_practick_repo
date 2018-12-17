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

            try
            {
                Municipality = menu(Municipality);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
            finally
            {
               

            }
            
            Console.Read();
        }

        static void print_count_of_piople(List<vlalin> vlalins)
        {

            Console.WriteLine(" Количество людей = " + vlalins.Count.ToString());

        }

        static void add_piople(List<vlalin> vlalins)
        {

            string name = String.Empty;
            name = check_param(" Введите имя: "); ;

            string surname = String.Empty;
            surname = check_param(" Введите фамилию: ");

            string lastname = String.Empty;
            lastname = check_param(" Введите отчество: ");
            try
            {
                string age = "";
                Console.Write(" Введите возраст: ");
                age = Console.ReadLine();

                if (check_number(age) == true)
                {
                    vlalins.Add(new vlalin(name, surname, lastname, Int32.Parse(age)));
                }
                else
                {
                    vlalins.Add(new vlalin(name, surname, lastname, 0));
                    throw new Exception();
                }


            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);

            }

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
                if (isNormalStr == true)
                    return input;
            } while (true);
        }

        static void add_people_by_user_count(List<vlalin> vlalins)
        {
            int x = user_count();

            for (int i = 0; i < x; i++)
            {
                add_piople(vlalins);
            }
        }
        // Создаёт нового человека и возвращает
        static vlalin random_person(List<vlalin> vlalins)
        {

            try
            {
                vlalin vlalin = new vlalin(vlalins[new Random().Next(vlalins.Count)]);
                return vlalin;
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            return null;

        }

        static bool check_number(string age)
        {
            foreach (var item in age)
            {
                if (Char.IsNumber(item) == false)
                {
                    return false;
                }
            }

            return true;

        }

        static int user_count()
        {
            int value = 0;
            Console.Write(" Какое количество людей Вы хотите добавить: ");
            Int32.TryParse(Console.ReadLine(), out value);

            return value;
        }

        static List<vlalin> menu(List<vlalin> Municipality)
        {
            try
            {
                add_people_by_user_count(Municipality);
                print_count_of_piople(Municipality);

               

                if (Municipality != null)
                {



                    if (Municipality.Count > 0)
                    {
                        //Console.WriteLine(random_person(Municipality).toString());


                        ////ваводим 32 черточки
                        //Console.WriteLine(new String('-', 32));
                        ////вызываем конструктор копирования (который создаст новго человека скопировав всю инфу с последнего в списке)
                        //vlalin tmp = new vlalin(Municipality.Last());
                        //Console.WriteLine(tmp.ToString());
                        Municipality.ForEach(x => Console.WriteLine(x.toString()));

                        change_settings(Municipality);
                    }

                }
                else
                    throw new Exception();
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                menu(Municipality);
            }

            return Municipality;
        }

        static void change_settings(List<vlalin> Municipality) 
        {
            Console.Clear();
            char change = ' ';
           
            int index = 1;
            try
            {
                foreach (var item in Municipality)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t" + index + "\n" + item.toString());

                    index++;
                }

                int choice = 0;
                Console.Write("\n Выбирете номер человека которого Вы хотите изменить: ");
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice < 0 || choice > Municipality.Count)
                    new Exception("Не верный номер человека!");
                Console.WriteLine(" 1 - Изменить имя ");
                Console.WriteLine(" 2 - Изменить фамилию ");
                Console.WriteLine(" 3 - Изменить отчество ");
                Console.WriteLine(" 4 - Изменить возраст ");

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine(" Введите новое имя: ");
                            string Name = Console.ReadLine();
                            Municipality[choice].name = Name;
                            break;
                        }


                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
          
        }

    }
}
