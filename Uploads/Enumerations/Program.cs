public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }


    public AgeGroupEnumeration AgeGroup { get; set; } // declaring with enum type
}


public enum AgeGroupEnumeration // implementing enumeration
{
    Child,
    Teenager,
    Adult,
    Senior
}
class Program
{
    static void Main()
    {
        Person p = new Person();

        p.Name = "Tyler";
        p.Email = "tyler@gmail.com";
        p.AgeGroup = AgeGroupEnumeration.Teenager; // use of enumeration


        System.Console.WriteLine(p.AgeGroup);


        System.Console.ReadKey();
    }
}
