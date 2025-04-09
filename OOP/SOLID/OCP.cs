namespace OOP.SOLID;
public class OCP
{
    public class BadRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    public class BadAreaCalculator
    {
        public double CalculateArea(BadRectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }

    public interface IShape
    {
        double Area();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
