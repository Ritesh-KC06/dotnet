using System.Drawing;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape{
    public double radius;

    public Circle(double radius){
        this.radius = radius;
    }

    public override double GetArea()
    {
        double Area = Math.PI * radius *radius;
        return Area;
    }
}

class Triangle : Shape{
    public double bottom;
    public double height;

    public Triangle(double bottom, double height){
        this.bottom = bottom;
        this.height = height;
    }

    public override double GetArea()
    {
        double Area = bottom * height;
        return Area;
    }
}
class Program
{
    static void Main(string[] args){

        Circle cl_1 = new Circle(25);
        Console.WriteLine($"Circle Radius:{cl_1.radius}, Circle Area:{cl_1.GetArea()}");

        Triangle Tr_1 = new Triangle(25.0, 30.0);
        Console.WriteLine($"Traingle Area:{Tr_1.GetArea()}");
    }
}