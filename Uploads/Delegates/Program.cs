public class Sample
{
    public void Add(double a, double b, double c)
    {
        System.Console.WriteLine(a + b + c);
    }
    public void Mult(double a, double b, double c)
    {
        System.Console.WriteLine(a * b * c);
    }
}
// create delegate type
public delegate void MyDelegate1(double a, double b, double c);
class Program
{
    static void Main()
    {
        Sample s = new Sample();

        MyDelegate1 d1 = new MyDelegate1(s.Add);
        MyDelegate1 d2 = new MyDelegate1(s.Mult);

        d1.Invoke(10, 20, 30);
        d2.Invoke(10, 20, 30);

        System.Console.WriteLine();

        MyDelegate1 d;
        d = new MyDelegate1(s.Add);
        d += new MyDelegate1(s.Mult); // adding second method to the same delegate reference
        d.Invoke(10, 20, 30);

        System.Console.ReadKey();
    }
}
