namespace OOP.Polymorphism.GoodExample;
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void Start() => Console.WriteLine("Car started...");

    public override void Stop() => Console.WriteLine("Car stopped...");

    public override void Drive() => Console.WriteLine("Car is driving...");
}
