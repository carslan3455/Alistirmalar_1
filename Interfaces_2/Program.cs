using System;

namespace Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]{ new Manager(), new Worker(), new Robot()};

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Manager(), new Worker()};

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    // SOLID -> I prensibi : Interface Segregation 
    interface IWorker
    {
        void Work();
       
    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();

    }

    class Manager : IWorker, IEat, ISalary  // 1 classs 1 den fazla interface implemente edilebilir 
    {
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        void IEat.Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat , ISalary
    {
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        void IEat.Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
