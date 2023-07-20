using System;


class Publisher
{
    public event Predicate<int> myEvent;

    public bool RaiseEvent(int a) // we bool return type
    {
        if (this.myEvent != null)
        {
            bool res = this.myEvent(a);
            return res;
        }
        else { return false; }
    }
}
class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        p.myEvent += (a) =>
        {
            return a >= 0;
        };

        System.Console.WriteLine(p.RaiseEvent(10));
        System.Console.WriteLine(p.RaiseEvent(-10));


        System.Console.ReadKey();
    }
}
