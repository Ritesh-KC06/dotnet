abstract class Shape{
    public abstract double CalculateArea();

    public void DisplayColor(string color){
        Console.WriteLine($"The shape is {color}");
    }
}

class Circle : Shape{
    public double radius;
    public Circle(double radius){
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape{
    public double height;
    public double width;

    public Rectangle(double width, double height){
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        double area = width * height;
        return area;
    }
}
class Program
{
    static void Main(string[] args){
        Circle crl_1 = new Circle(5.0);
        crl_1.DisplayColor("Red");
        Console.WriteLine($"Circle Area: {crl_1.CalculateArea()}");

        Rectangle Rct_1 = new Rectangle(20.0, 30.0);
        Console.WriteLine($"Rectangle Area- {Rct_1.CalculateArea()}");
    }
}
