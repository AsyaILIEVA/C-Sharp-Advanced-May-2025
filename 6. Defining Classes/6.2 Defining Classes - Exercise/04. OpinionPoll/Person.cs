using System.Security.Cryptography;

namespace DefiningClasses;


public class Person
{
    //Fields: (usually private)
    private string name;
    private int age;

    public string Name //property (usually public)
    {
        get
        {
            return this.name; // this. -> property works as a shield over field;
        }
        set
        {
            this.name = value;
        }
    }

    public int Age //property
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public Person()
        : this(age: 1)
    {

    }

    public Person(int age)
        : this(name: "No name", age)
    {

    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
        => $"{this.Name} - {this.Age}";
}