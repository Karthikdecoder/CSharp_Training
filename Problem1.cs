using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        double x = Math.Round(5.4);

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        int i = 0;
        int step = 1;

        if(x < 0)
        {
            step = -1;
        }

        while(i != x)
        {
            if( i%2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }

            i = i+step;
        }

        if (i % 2 == 0)
        {
            even.Add(i);
        }
        else
        {
            odd.Add(i);
        }

        even.ForEach(num => System.Console.WriteLine(num));
        odd.ForEach(num => System.Console.WriteLine(num));

        System.Console.ReadKey();
    }
}
