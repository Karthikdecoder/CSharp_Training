using System;
class Program
{
    static void Main()
    {
        Tuple<string, int, double> t1 = new Tuple<string, int, double>("Tyler", 12, 2.3);
        var t2 = Tuple.Create(1, 2.3333, "Edward");
        System.Console.WriteLine(t1.Item2);
        System.Console.WriteLine(t2.Item2);
        System.Console.ReadKey();
    }
}
