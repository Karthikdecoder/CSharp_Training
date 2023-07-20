public class Sample
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

// create delegate type
public delegate int MyDelegate1(int a, int b);

class Program
{
    static void Main()
    {
        Sample s = new Sample();
        MyDelegate1 d;
        d = new MyDelegate1(s.Add); //Delegates are used to pass methods as arguments to other methods.
        System.Console.WriteLine(d.Invoke(10, 20));
        System.Console.ReadKey();
    }
}
