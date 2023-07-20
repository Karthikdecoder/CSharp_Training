/*
 The Publisher class creates an event.
The Subscriber class subscribes to the event; that means an "event handler" method is created in the subscriber class. The "event handler" method is nothing but the method which is dedicated to be executed when the event is raised.
The publisher class can send (raise) events.
Every time, when the event is raised by the publisher, the corresponding "event handler" method executes automatically.
*/


//1. Create a Delegate
public delegate void md(int a, int b);
//2. Create an Event in Publisher class
public class Publisher
{
    private md eventVariable;
    public event md MyEvent;
    //3. Raise the event in Publishder class

    public void RaiseEvent(int a, int b)
    {
        if (MyEvent != null)
        {
            MyEvent(a, b);
        }
    }
}


//4. Create Event Handler Method in Subscriber class
public class Subscriber
{
    public void Add(int a, int b)
    {
        int c = a + b;
        System.Console.WriteLine(c);
    }
}
class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        Subscriber s = new Subscriber();
        //5. Subscribe to the Event (Inside or outside the subscriber class)
        p.MyEvent += s.Add;
        p.RaiseEvent(1, 2);
        System.Console.ReadKey();
    }
}

/*
So overall, whenever somebody subscribes to the myEvent, the corresponding method reference will be stored in the myDelegate.
And in the same way, whenever somebody unsubscribes to the same, the corresponding method reference will be removed from the myDelegate.


Events are basically signals or notifications from one-class to another -class that some important data has been changed in the publisher class.
Events can be raised only within the same class, in which they are declared i.e. we can call only inside the publisher class.
Events can be static, virtual, sealed and abstract. That means we can create events even in interfaces also.
Events throw the exception when you invoke them without at least one subscriber.
That's why, it is better to check whether there is one subscriber;
then only you require to raise the event.
And it's not a good idea to return values from events.
That means, the delegate type of events must be always void.

*/
