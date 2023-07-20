public partial class Product
{
    private int _productId;
    public int ProductId
    {
        set { this._productId = value; }
        get { return this._productId; }
    }

    partial void GetTax(); // partial method declaration
}



public partial class Product
{
    private double _cost;

    public double Cost
    {
        set { this._cost = value; }
        get { return this._cost; }
    }

    public void GetCallTax() // partial method implementation
    {
        GetTax();
    }

}



public partial class Product
{
    partial void GetTax() // partial method cannot be return type
    {
        double tax = Cost * 10 / 100;
        System.Console.WriteLine(tax);
    }
}



class Program
{
    static void Main()
    {
        Product p = new Product();

        p.ProductId = 1;
        p.Cost = 100;

        System.Console.WriteLine(p.ProductId);
        System.Console.WriteLine(p.Cost);
        p.GetCallTax(); // calling partial method

        System.Console.ReadKey();
    }
}
