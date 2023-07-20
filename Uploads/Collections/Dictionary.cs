
using System.Collections.Generic;
using System.Xml;

public class Program
{
    public static void Main()
    {
        Dictionary<string, object> d = new Dictionary<string, object>();

        for(int i = 0; i < 5; i++)
        {
            string key = System.Console.ReadLine();
            object obj = int.Parse(System.Console.ReadLine());
            d.Add(key, obj);
        }

        foreach(string key in d.Keys)
        {
            System.Console.WriteLine(key + ":" + d[key]);
        }

        System.Console.ReadKey();
    }
}
