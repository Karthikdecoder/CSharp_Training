class Product
{
    public static int totalNoOfProduct; // static field
    public const string CategoryName = "Groceries"; // constant field
    public readonly string dateOfPurchase; // readonly field

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToLongDateString(); // outside the constructor nowhere we can modify the read only field
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product();
        Product.totalNoOfProduct++;

        Product p2 = new Product();
        Product.totalNoOfProduct++;

        Product p3 = new Product();
        Product.totalNoOfProduct++;

        System.Console.WriteLine("Total no of products: " + Product.totalNoOfProduct);
        System.Console.WriteLine("Category of products: " + Product.CategoryName);

        System.Console.WriteLine("Date of purchase for product 1: " + p1.dateOfPurchase);

        System.Console.WriteLine("Date of purchase for product 2: " + p2.dateOfPurchase);

        System.Console.WriteLine("Date of purchase for product 3: " + p3.dateOfPurchase);

        System.Console.ReadKey();
    }
}
