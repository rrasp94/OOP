using OOP.Polymorphism;

namespace OOP.Aggregation;
public class Aggregation
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address.Street}, {Address.City}, {Address.ZipCode}");
        }
    }

    public static void Main()
    {
        try
        {
            Address address = new Address("123 Main St", "New York", "10001");
            Console.WriteLine(address.City);
            Person person = new Person("John Doe", address);
            person.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }

    }
}
