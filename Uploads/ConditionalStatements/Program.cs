using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        bool flag1 = true;

        System.Console.WriteLine("input: ");
        int i = int.Parse(System.Console.ReadLine());

    Mylabel:

        System.Console.WriteLine("Enter again");
        i = int.Parse(System.Console.ReadLine());

        while (flag1 == true)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine("Success");
                break;
            }
            else
            {
                goto Mylabel;
            }
        }

        System.Console.WriteLine("end");

        System.Console.ReadKey();
    }
}
