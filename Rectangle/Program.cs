class Rectangle{
    public int height;
    public int width;

    public int Rect_Area(){
        //this.height = height;
        //this.width = width;

        int Area = height * width;
        return Area;
    }

    public int Rect_Perimeter(){
        //this.height = height;
        //this.width = width;

        int Perimeter = (2 * (height + width));
        return Perimeter;
    }
}
class Program
{
    static void Main(string[] args){

        Rectangle RCT_1 = new Rectangle();
        RCT_1.height = 30;
        RCT_1.width = 15;

        Console.WriteLine($"Area of Rectangle:{RCT_1.Rect_Area()}");
        Console.WriteLine($"Perimeter of Rectangle- {RCT_1.Rect_Perimeter()}");
    }
}