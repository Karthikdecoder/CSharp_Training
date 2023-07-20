public class PSample
{
    private string s1;
    private string s2;
    public PSample(string s1, string s2)
    {
        this.s1 = s1;
        this.s2 = s2;
    }
    public string S1
    {
        get
        {
            return s1;
        }
    }
    public string S2
    {
        get
        {
            return s2;
        }
    }
}
public class CSample : PSample // inheriting parent’s class constructor to child class
{
    private string s3;
    public CSample(string s1, string s2, string s3) : base(s1, s2) // should include parent constructor
    {
        this.s3 = s3;
    }
    public string S3
    {
        get
        {
            return s3;
        }
    }
}
class Program
{
    static void Main()
    {
        PSample p = new PSample("a", "b");
        CSample c = new CSample("a", "b", "c"); // should include values for parent constructor
        System.Console.WriteLine(p.S1);
        System.Console.WriteLine(p.S2);
        System.Console.WriteLine(c.S1);
        System.Console.WriteLine(c.S2);
        System.Console.WriteLine(c.S3);
        System.Console.ReadKey();
    }
}
