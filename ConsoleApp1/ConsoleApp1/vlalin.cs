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

        public vlalin(string name)
        {
            this.name = name;
        }

        public vlalin(string name, string surname, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            this.surname = surname;
        }

        public string ToString()
        {
            return $" Ваше имя {name}\n Ваша фамилия {surname}\n Ваше отчество {lastname}\n Ваш возраст {age}";
        }

        //конструктор копироания
       public vlalin(vlalin vlad)
        {
            this.age = vlad.age;
            this.lastname = vlad.lastname;
            this.name = vlad.name;
            this.surname = vlad.surname;
        }


    }
}
