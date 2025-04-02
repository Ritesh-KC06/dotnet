class BankAccount{
    private double balance;
    public int accountNumber;

    public BankAccount(int accountNumber, double initialBalance){
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(double amount){
        if(amount > 0){
            balance = balance + amount;
            Console.WriteLine($"Deposited:{amount}, New Balance:{balance}");
        } else{
            Console.WriteLine("Invalid Deposit amount");
        }
    }

    public void Withdraw(double amount){
        if(amount>0 && balance>=amount){
            balance = balance - amount;
            Console.WriteLine($"Withdrawn:{amount}, New Balance:{balance}");
        }
    }

    public double GetBalance(){
        return balance;
    }
}

class Program
{
    static void Main(string[] args){
        BankAccount account1 = new BankAccount(12345, 1000.0);
        account1.Deposit(500.0);
        account1.Withdraw(200.0);
        Console.WriteLine($"Current Balance:{account1.GetBalance()}");
    }
}
