using System;

public class Publisher
{
    public event Func<int, int, int> MyEvent; // no need of delegate type when we use func

    public int RaiseEvent(int a, int b) // return type
    {
        if (MyEvent != null)
        {
            int x = (MyEvent(a, b));
            return x;
        }
        else
        {
            return 0;
        }
    }
}
class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
      
        p.MyEvent += (a, b) => (a + b);


        System.Console.WriteLine(p.RaiseEvent(1, 2));

        System.Console.ReadKey();
    }
}
