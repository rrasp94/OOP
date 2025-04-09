namespace OOP.Polymorphism;
public class OperatorOverloading
{
    public static void Main()
    {
        try
        {
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine("Sum of numbers is: " + sum);

            string a = "Hello";
            string b = "World";
            string result = a + b;
            Console.WriteLine("Concatenated string is: " + result);
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
