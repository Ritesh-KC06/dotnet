class Book{
    public string Title;
    public string Auther;
    public double Price;

    public void DisplayDetails(){
        Console.WriteLine($"Book Title:{Title}, Book Auther:{Auther}, Book Price:{Price}");
    }
}
class Program
{
    static void Main(string[] args){

        Book Book_1 = new Book();
        Book_1.Title = "ABC";
        Book_1.Auther = "XYZ";
        Book_1.Price = 231.25;

        Book_1.DisplayDetails();
    }
}