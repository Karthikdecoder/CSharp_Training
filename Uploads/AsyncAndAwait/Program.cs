using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Method1();
        Method2();

        Console.ReadKey();
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 1 is running");
                Task.Delay(1000).Wait();
            }
        });
    }

    public static void Method2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method 2 is running");
            Task.Delay(1000).Wait();
        }
    }
}


