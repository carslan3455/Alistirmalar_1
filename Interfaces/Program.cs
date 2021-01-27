using System;

namespace Interfaces_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfaceExamp();
            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfaceExamp()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ihsan", 
                LastName = "A",
                Address = "Istanbul"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Sinem",
                LastName = "A",
                Departmant = "Veteriner"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson   // Soyut varliktir implemente ettiklerimiz somut varlikdir
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson    // tum program bittikten sonra calisan eklesek bile hersey duzgun calisacaktir
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)   // implemente yaptigimiz icin Person olarak gondererek her iki class yollayabildik
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
