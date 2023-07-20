class Sample<T>
{
    public void add(T a, T b)
    {
        dynamic a1 = a;
        dynamic b1 = b;
        System.Console.WriteLine(a1 + b1); // if we use operators in generics then use dynamic keyword
    }
    public void sub(T a, T b)
    {
        dynamic a1 = a;
        dynamic b1 = b;
        System.Console.WriteLine(a1 - b1);
    }
}
class Program
{
    static void Main()
    {
        Sample<int> s = new Sample<int>();
        s.add(3, 2);
        s.sub(3, 2);
        System.Console.ReadKey();
    }
}
