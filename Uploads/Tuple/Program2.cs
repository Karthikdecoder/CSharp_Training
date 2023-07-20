using System;
class Program
{
    static void dispTup(Tuple<int, int, int> t1) //Tuple as a Method Parameter
    {
        Console.WriteLine(t1.Item1);
        Console.WriteLine(t1.Item2);
        Console.WriteLine(t1.Item3);
    }
    static void Main()
    {
        var t1 = Tuple.Create(1, 2, 3);
        dispTup(t1);
        System.Console.ReadKey();
    }
}
