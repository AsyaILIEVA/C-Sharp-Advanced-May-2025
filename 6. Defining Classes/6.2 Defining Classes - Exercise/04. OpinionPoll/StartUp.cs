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
            //Person p1 = new Person();
            //p1.Name = "Peter";
            //p1.Age = 20;

            ////Object initializer
            //Person p2 = new Person() { Name = "George", Age = 18 };
            ////Person p3 = new Person { Name = "Jose", Age = 43 };

            //// Constructor
            //Person p3 = new Person("Jose", 43);

            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                int age = int.Parse(data[1]);
                //Person person = new Person(name, age);
                people[i] = new Person(name, age);
                //family.AddMember(person);
            }
            //Person oldestMember = family.GetOldestMember();
            //Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

            //Override "ToString()"
            //Person oldestMember = family.GetOldestMember();
            //Console.WriteLine(oldestMember);


            foreach (Person person in people.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine(person);
            }
        }
    }
}
