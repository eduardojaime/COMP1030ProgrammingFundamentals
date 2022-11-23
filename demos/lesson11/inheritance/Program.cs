namespace inheritance;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Shapes!");
        // Abstract classes cannot be instantiated
        // Shape myShape = new Shape();

        // Concrete classes: Rectangle and Triangle
        Rectangle myRectangle = new Rectangle();
        myRectangle.Height = 100;
        myRectangle.Width = 150;

        // call the methods
        myRectangle.PrintShape();
        double rectanglePerimeter = myRectangle.CalculatePerimeter();
        Console.WriteLine($"Rectangle perimeter is {rectanglePerimeter}");
        double rectangleArea = myRectangle.CalculateArea();
        Console.WriteLine($"Rectangle area is {rectangleArea}");

        Triangle myTriangle = new Triangle();
        myTriangle.SideA = 10.0;
        myTriangle.SideB = 15.0;
        myTriangle.SideC = 20.0;

        myTriangle.PrintShape();
        double trianglePerimeter = myTriangle.CalculatePerimeter();
        Console.WriteLine($"Triangle perimeter is {trianglePerimeter}");
        double triangleArea = myTriangle.CalculateArea();
        Console.WriteLine($"Triangle area is {triangleArea}");
    }
}
