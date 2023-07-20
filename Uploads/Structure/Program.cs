public struct Person
{
    public string PersonName
    {
        get; set;
    }
    public string PersonEmail
    {
        get; set;
    }
    public override bool Equals(object obj)
    {
        Person p = (Person)obj; // Type casting obj to Person

        if (this.PersonName == p.PersonName && this.PersonEmail == p.PersonEmail)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main()
    {
        System.Object p1 = new Person() { PersonName = "Tyler", PersonEmail = "tyler@hotmail.com" };
        System.Object p2 = new Person() { PersonName = "Tyler", PersonEmail = "tyler@hotmail.com" };
        System.Console.WriteLine(p1.Equals(p2));
        System.Console.WriteLine((p1 == p2));
        System.Console.WriteLine();
        System.Console.WriteLine(p1.GetHashCode());
        System.Console.WriteLine(p2.GetHashCode());
        System.Console.WriteLine();
        System.Console.WriteLine(p1.GetType());
        System.Console.WriteLine(p2.GetType());
        System.Console.WriteLine();
        System.Console.WriteLine(p1.ToString()); // To return custom string by overriding the parent class method in sub class child method
        System.Console.WriteLine(p2.ToString());
        System.Console.WriteLine();

        System.Console.ReadKey();
    }

}