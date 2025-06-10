using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;

namespace BakeryOpenning
{
    public class Bakery
    {

//Next, write a C# class Bakery that has data (a collection, which stores the entity Employee). All entities inside the repository have the same properties. Also, the Bakery class should have those properties:
//Name: string
//Capacity: int
        List<Employee> employees;
        public string Name { get; set; }
        public int Capacity { get; set; }
        //The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection.Implement the following features:
        //Field data – collection that holds added Employees

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();

        }
        //Method Add(Employee employee) – adds an entity to the data if there is room for him/her.
        public void Add(Employee employee)
        {
            if (Capacity > employees.Count)
            {
                employees.Add(employee);
            }
        }
        //Method Remove(string name) – removes an employee by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            if (employees.Any(e => e.Name == name))
            {
                Employee removedEmployee = employees.Where(
                    e => e.Name == name).First();
                employees.Remove(removedEmployee);
                    return true;
            }
            return false;
        }
        //Method GetOldestEmployee() – returns the oldest employee.
        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = employees.OrderByDescending(e => e.Age).First();
            return oldestEmployee;
        }
        //Method GetEmployee(string name) – returns the employee with the given name.
        public Employee GetEmployee(string name)
        {
            Employee employee = employees.FirstOrDefault(e => e.Name == name);
            return employee;
        }
        //Getter Count – returns the number of employees.
        public int Count => employees.Count;

        //Report() – returns a string in the following format:
        //o"Employees working at Bakery {bakeryName}:
        //{Employee1}
        //{Employee2}
        //(…)"

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (Employee employee in employees)
            {
                sb.AppendLine($"{employee.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
