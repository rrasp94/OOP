namespace OOP.SOLID;
public class LSP
{
    public class BadBird
    {
        public virtual void Fly() => Console.WriteLine("Bird is flying.");
    }

    public class BadPenguin : BadBird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly!");
        }
    }

    public interface IFly
    {
        void Fly();
    }

    public class Bird : IFly
    {
        public void Fly() => Console.WriteLine("Bird is flying.");
    }

    public class Penguin : IFly
    {
        public void Fly() => Console.WriteLine("Penguin can't fly!.");
    }
}
