public delegate void func(int n);

class Program
{
    static int num = 10;
    static void Main()
    {
        func f = delegate (int n)
        {
            string a = "hi";
            System.Console.WriteLine("Anonymous method " + n);
            System.Console.WriteLine("Anonymous method {0} {1}", n, a);
        };


        f(num);


        System.Console.ReadKey();
    }
}
