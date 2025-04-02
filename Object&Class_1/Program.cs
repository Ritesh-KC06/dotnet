class Car
{
    public string make;
    public string model;
    public int year;

    public void DisplayInfo(){
        Console.WriteLine($"Make:{make}, Model: {model}, Year:{year}");
    }
    
}
class Program
{
    static void Main(string[] args){
        Car myCar = new Car();

        myCar.make = "Toyota";
        myCar.model = "Camry";
        myCar.year = 2022;

        myCar.DisplayInfo();

        Car myCar2 = new Car();

        myCar2.make = "Maruti";
        myCar2.model = "Baleno";
        myCar2.DisplayInfo();
    }
}
