namespace FacadeDesignPattern;

internal class Payment
{
    internal void GetPayment(Customer customer)
    {
        Console.WriteLine($"Payment completed from the {customer.CustomerName}");
    }
}
