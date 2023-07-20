public class Product
{
    public double ProductCost { get; set; }
    public double DiscountPercentage { get; set; }
}


public static class ProductExtension
{
    public static void GetDiscount(this Product obj) // you can access the existing class properties using 'this' keyword
    {
        double res = (obj.ProductCost * obj.DiscountPercentage) / 100;
        System.Console.WriteLine(res);
    }
}


class Program
{
    static void Main()
    {
        Product p = new Product();

        p.ProductCost = 100;
        p.DiscountPercentage = 100;
        p.GetDiscount();
        
        System.Console.ReadKey();
    }
}
