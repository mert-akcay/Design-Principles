namespace FacadeDesignPattern;

internal class Invoice
{
    internal void SendInvoice(Customer customer)
    {
        Console.WriteLine($"Invoice has sent to {customer.CustomerName}");
    }
}

