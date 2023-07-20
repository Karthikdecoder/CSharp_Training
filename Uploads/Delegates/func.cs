using System;


public class Publisher
{
    public event Action<int, int> MyEvent; // use of action

    public void RaiseEvent(int a, int b) // we use void event handler
    {
        if (MyEvent != null)
        {
            this.MyEvent(a, b);
        }
    }
}

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        

        p.MyEvent += (a, b) => System.Console.WriteLine(a + b);


        p.RaiseEvent(1, 2);


        System.Console.ReadKey();
    }
}
