abstract class Car // creating an abstract class
{
    public abstract void carCompanyName(); // creating an abstract method
    public void drive()
    {
        System.Console.WriteLine("car drives....");
    }
}
class Bmw : Car
{
    public override void carCompanyName() // overriding the abstract method in Bmw, which is present in abstract Car class
    {
        System.Console.WriteLine("BMW Company");
    }
}
class Program
{
    static void Main()
    {
        Bmw b = new Bmw();
        b.carCompanyName();
        b.drive();
    }
}
