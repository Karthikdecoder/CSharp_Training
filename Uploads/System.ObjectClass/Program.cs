class Program
{
    static void Main()
    {
        int x1 = 1;
        System.Console.WriteLine(x1.GetType());

        object obj1 = x1; // Boxing
        System.Console.WriteLine(obj1.GetType());

        object obj2 = 2;
        System.Console.WriteLine(obj2.GetType());
        int x2 = (int)obj2; // Unboxing


        System.Console.WriteLine(x1);
        System.Console.WriteLine(x1.GetType());
        System.Console.WriteLine(obj1);
        System.Console.WriteLine(obj1.GetType());
        System.Console.WriteLine();
        System.Console.WriteLine(x2);
        System.Console.WriteLine(x2.GetType());
        System.Console.WriteLine(obj2);
        System.Console.WriteLine(obj2.GetType());
        System.Console.ReadKey();


        System.Console.ReadKey();

    }
}
