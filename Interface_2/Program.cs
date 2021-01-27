using System;

namespace Interface_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Interface new lenemez
            // IPersonManager personManager = new IPersonManager();

            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());   // Stajyer methodu sonradan eklenmesine ragmen sistem bozulmadi

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        // unimplemented operation - Gövdesi olmayan method
        void Add();
        void Update();
    }

    //inherits -> class larda   -------    implements -> interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // müsteri ekleme kodlari yazilir
            Console.WriteLine("Müsteri eklendi...");
        }

        public void Update()
        {
            // müsteri guncelleme kodlari yazilir
            Console.WriteLine("Müsteri güncellendi...");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // calisan ekleme kodlari yazilir
            Console.WriteLine("Calisan eklendi...");
        }
        public void Update()
        {
            // calisan guncelleme kodlari yazilir
            Console.WriteLine("Calisan güncellendi...");
        }
    }

    class InternManager : IPersonManager    // Intern -> Stajyer
    {
        public void Add()
        {
            // Stajyer ekleme kodlari yazilir
            Console.WriteLine("Stajyer eklendi...");
        }
        public void Update()
        {
            // Stajyer guncelleme kodlari yazilir
            Console.WriteLine("Stajyer güncellendi...");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
    }
}
