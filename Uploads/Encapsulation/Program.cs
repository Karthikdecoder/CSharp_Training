public class BankApp
{
    public static string bankName = "Goku"; // static field used here
    public const int bankNo = 1; // constant field used here
    private int accNo;
    private string accUserName;
    private string accType;
    public int AccNo // Properties used here to get and set the private instance field in bank app class
    {
        get { return accNo; }
        set { this.accNo = value; }
    } // note the syntax for property, get, set.
    public string AccUserName
    {
        get { return accUserName; }
        set { this.accUserName = value; }
    }
    public string AccType
    {
        get { return accType; }
        set { this.accType = value; }
    }
    public void display()
    {
        System.Console.WriteLine("Account no: " + accNo);
        System.Console.WriteLine("Account name: " + accUserName);
        System.Console.WriteLine("Account type: " + accType);
    }
}
class Program
{
    static void Main()
    {
        BankApp b = new BankApp(); // creating object and storing it to the reference variable (b)
        System.Console.WriteLine("Bank Name: " + BankApp.bankName);
        System.Console.WriteLine("Bank Number: " + BankApp.bankNo);
        System.Console.WriteLine();
        b.AccNo = 123;
        b.AccUserName = "Nitish";
        b.AccType = "Savings Account";
        b.display();
        System.Console.ReadKey();
    }
}
