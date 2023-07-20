public delegate void MyDelegateType(int a, int b);


public class Publisher
{
    private MyDelegateType MyDelegate;


    public event MyDelegateType MyEvent;


    public void RaiseEvent(int a, int b)
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


        p.MyEvent += (a, b) => System.Console.Write(a + b); // inline lambda expression


        p.RaiseEvent(1, 2);


        System.Console.ReadKey();


    }
}
