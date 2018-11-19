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
            vlalin vlalin = new vlalin("vlad", "Linskiy", "Dmitievish", 21);
            vlalin vova = new vlalin("Vova", "Lavrov", "Goose", 21);
            vlalin ruslan = new vlalin("Ruslan", "Fateev", "Viktoovich", 21);
            vlalin misha = new vlalin("Misha", "Kolygin", "Kolygin", 21);
            List<vlalin> Municipality = new List<vlalin>();

            Municipality.Add(vlalin);
           
            Municipality.Add(vova);
            
            Municipality.Add(ruslan);
            
            Municipality.Add(misha);


            Municipality.ForEach( x => x.info());




            Console.Read();


        }
    }
}
