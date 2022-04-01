namespace FacadeDesignPattern;

internal class Stock
{
    internal void CheckStock(Product product)
    {
        Console.WriteLine($"{product.ProductName}'s Stock checked successfully");
    }
}

