using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Peter";
            p1.Age = 20;

            //Object initializer
            Person p2 = new Person() { Name = "George", Age = 18 };
            //Person p3 = new Person { Name = "Jose", Age = 43 };

            // Constructor
            Person p3 = new Person("Jose", 43);
        }
    }
}
