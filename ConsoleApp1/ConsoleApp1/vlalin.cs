using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class vlalin
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }

        public vlalin(string name, string surname, string lastname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.age = age;
        }

        public void info()
        {
            

            Console.WriteLine("Ваше имя - " + name);
            Console.WriteLine("Ваша фамилия - " + surname);
            Console.WriteLine("Ваше отчество - " + lastname);
            Console.WriteLine("Ваш возраст - " + age);
            Console.WriteLine("\n");

           
        }


       


    }
}
