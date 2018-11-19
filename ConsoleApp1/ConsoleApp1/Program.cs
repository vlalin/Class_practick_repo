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
            List<vlalin> Municipality = new List<vlalin>();

            Municipality.Add(vlalin);

            Municipality.ForEach(x => x.info());




            Console.Read();


        }
    }
}
