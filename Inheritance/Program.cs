using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[] 
            {
            new Customer{FirstName = "Sinem" }, 
            new Student {FirstName = "Ihsan" },
            new Person {FirstName = "Ess" } 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person  // Person da bir varliktir. new yapilir. Interface ler soyuttur new yapilamaz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {

    }

    interface IPerson2
    {

    }

    class Customer:Person ,IPerson,IPerson2  
        // bir varlik 1 tane Inheritance alabilir. birden fazla Interface alabilir
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Depertmant { get; set; }
    }
}
