using System;
public class InvalidException : Exception
{
    public InvalidException()
    {

    }
}
class Program
{
    static void check(int b)
    {
        if (b == 0) throw new InvalidException();

        else
        {
            int a = 10;
            int c = a / b;
            Console.WriteLine(c);
        }
    }
    static void Main()
    {
        try
        {
            check(0);
        }
        catch (InvalidException e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("Rest of the code");
        Console.ReadKey();
    }
}
