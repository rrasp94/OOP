namespace OOP.SOLID;
public class ISP
{
    public interface IWorker
    {
        void Work();
        void Eat();
        void Teaching();
    }

    public class BadTeacher : IWorker
    {
        public void Work() => Console.WriteLine("Worker is working.");
        public void Eat() => Console.WriteLine("Worker is eating.");
        public void Teaching() => Console.WriteLine("Teaching...");
    }

    public class BadStudent : IWorker
    {
        public void Work() => Console.WriteLine("Worker is working.");
        public void Eat() => Console.WriteLine("Worker is eating.");
        public void Teaching() => throw new NotImplementedException("Student can't teach.");
    }


    public interface IWork
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();
    }

    public interface ITeach
    {
        void Teaching();
    }

    public class Worker : IWork, IEat
    {
        public void Work() => Console.WriteLine("Worker is working.");
        public void Eat() => Console.WriteLine("Worker is eating.");
    }

    public class Teacher : IWork, IEat, ITeach
    {
        public void Work() => Console.WriteLine("Worker is working.");
        public void Eat() => Console.WriteLine("Worker is eating.");
        public void Teaching() => Console.WriteLine("Teaching...");
    }

    public class Student : IWork, IEat
    {
        public void Work() => Console.WriteLine("Worker is working.");
        public void Eat() => Console.WriteLine("Worker is eating.");
    }
}