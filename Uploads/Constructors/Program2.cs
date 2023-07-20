class Car
{
    private string name;
    public Car(string name) // Here we create a constructor 
    {
        this.name = name;
    }
    public void display()
    {
        System.Console.WriteLine("Car name is " + this.name);
    }
}
class Program
{
    static void Main()
    {
        Car c = new Car("BMW"); // Here we pass the argument for constructor
        c.display();
        System.Console.ReadKey();
    }
}
