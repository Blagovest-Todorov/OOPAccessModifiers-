using System;

namespace _01.OOP
{
    class Person
    {
        private string field1; // We make here a property --property is member class that  provides 
        protected string field2;
        internal string field3;
        public string field4;
        protected internal string field5; // never used protected internal both at the same time


        // level of acess mechanism to read , write th e value of a given field
        // private -give us level of accessibility only into the class between{opening and closing brackets} of the class
        // protected  says--level of acessibility into the class opening { and closing  }and in all its inherited 
        // classes-child classes, i e, acessible uin paren and all its child classes; inhereted classes
        // internal says this field is acessible everiwhere in  my Project Solution ;]
        // public -all acessible , from  everiwhere ! 
    }

    class Program
    {
        static void Main(string[] args)
        {           
            Person p1 = new Person(); // creating an object -> an instance of the class Person
            p1.Name = "Pesho";
            Console.WriteLine(p1.Name);
            Person p2 = new Person(); // acsess modifiers we use to control the acess  
        }
    }
}
