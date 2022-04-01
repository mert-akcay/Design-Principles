namespace SOLID.Open_Closed;
public class GeometricShapes
{
    public interface IShape
    {
        public double Area();
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
            return Radius * Radius * Math.PI;
        }
    }

    public double Area(IShape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }

        return area;
    }
}
