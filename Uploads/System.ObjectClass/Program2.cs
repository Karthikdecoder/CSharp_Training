class Class1
{
    public override string ToString()
    {
        return "Class1.ToString";
    }
}
class Program
{
    static void Main()
    {
        Class1 c1, c2;

        c1 = new Class1();
        c2 = new Class1();

        bool b = c1.Equals(c2); // returns if both are same or not
        System.Console.WriteLine(b);
        System.Console.WriteLine();

        int c = c1.GetHashCode(); // return the hashcode
        System.Console.WriteLine(c);
        System.Console.WriteLine();

        string t = c1.GetType().ToString(); // return the class name of the respective object
        System.Console.WriteLine(t);
        System.Console.WriteLine();

        string s = c1.ToString(); // return the string of that particular object
        System.Console.WriteLine(s);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}
