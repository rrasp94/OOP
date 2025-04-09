namespace OOP.Polymorphism;
public class MethodOverloading
{
    public void TotalSum(int a, int b)
    {
        Console.WriteLine("Sum of numbers is " + (a + b));
    }

    public void TotalSum(double a, double b)
    {
        Console.WriteLine("Sum of numbers is " + (a + b));
    }

    public void TotalSum(int a, int b, int c)
    {
        Console.WriteLine("Sum of numbers is " + (a + b + c));
    }

    public void Display(int a)
    {
        Console.WriteLine("Value of a is " + a);
    }

    public void Display(int a, double b)
    {
        Console.WriteLine("Value of a is " + a + " and " + b);
    }

    public static void Main()
    {
        try
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.TotalSum(10, 20);
            methodOverloading.TotalSum(10.5, 20.5);
            methodOverloading.TotalSum(10, 20, 30);
            methodOverloading.Display(10);
            methodOverloading.Display(10, 20.5);
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
