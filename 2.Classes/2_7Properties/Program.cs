using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    class Program
    {
        static void Main(string[] arg)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);



        }
    }
    
    
}