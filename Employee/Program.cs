class Employee
{
    public string name;
    public int employeeID;
    public decimal salary;

    public Employee (string name, int employeeID, decimal salary){
        this.name = name;
        this.employeeID = employeeID;
        this.salary = salary;
    }

    public decimal IncreaseSalary(decimal incrementPercentage){
        decimal incrementAmount = (incrementPercentage/100)*salary;
        Console.WriteLine($"The increment Amount is- :{incrementAmount}");
        salary = ((incrementPercentage/100)*salary) + salary;
        return salary;
    }

    public void DisplayEmployeeDetails(){
        Console.WriteLine($"Employee Name:{name}, EmployeeID:{employeeID}, Employee Salary:{salary}");
    }
}
class Program
{
    static void Main(string[] args){
        Employee emply1 = new Employee("Ritesh", 221, 5000);
        emply1.DisplayEmployeeDetails();
        emply1.IncreaseSalary(15);
        emply1.DisplayEmployeeDetails();
    }
}