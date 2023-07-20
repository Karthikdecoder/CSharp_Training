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
        bool b = c1.Equals(c2);
        System.Console.WriteLine(b);
        System.Console.WriteLine();
        int c = c1.GetHashCode();
        System.Console.WriteLine(c);
        System.Console.WriteLine();
        string t = c1.GetType().ToString();
        System.Console.WriteLine(t);
        System.Console.WriteLine();
        string s = c1.ToString();
        System.Console.WriteLine(s);
        System.Console.WriteLine();
        System.Console.ReadKey();
    }
}
