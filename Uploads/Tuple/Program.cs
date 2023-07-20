using System;

class Program
{
    static Tuple<int, int, int> DispTup(int a, int b, int c) // Tuple as a Return Type
    {
        return Tuple.Create(a, b, c);
    }
    static void Main()
    {
        var t1 = DispTup(1,2,3);

        Console.WriteLine(t1.Item1);
        Console.WriteLine(t1.Item2);
        Console.WriteLine(t1.Item3);

        System.Console.ReadKey();
    }
}
