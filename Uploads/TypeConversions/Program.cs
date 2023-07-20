class Program
{

    static void Main()
    {
        // Implicit casting
        int x1 = 10;
        long y1 = x1;

        // Explicit casting
        long x2 = 1000000000000000;
        int y2 = (int)x2;

        // Try Parse
        string x3 = "123";
        bool b = int.TryParse(x3, out int y3); // When this is true, it means type got converted

        // Conversion methods
        long x4 = 1000000;
        int y4 = System.Convert.ToInt32(x4);

        System.Console.WriteLine(y1);
        System.Console.WriteLine(y2);
        System.Console.WriteLine(y3);
        System.Console.WriteLine(y4);

        System.Console.ReadKey();

    }
}

