public class Program
{
    public static double DivideNumbers(double numerator, double denominator){
        if(denominator == 0){
            Console.WriteLine("Error: Divison by zero is not allowed.");
            return double.NaN;
        } else {
            double result = numerator/denominator;
            return result;
        }
    }
    public static void Main(){
        //Attempt to divide 10 by 0
        Console.WriteLine("Please give Numerator input- ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please give Denominator input- ");
        double B = Convert.ToDouble(Console.ReadLine());
        double result = DivideNumbers(A, B);
        Console.WriteLine("The result is: " + result);
    }
}
