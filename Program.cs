using System;

namespace _01.OOP
{
    class Person
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Name = "Pesho"
            };
            Person p2 = new Person()
            {
                Name = "Gosho"
            };
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
        }
    }
}
