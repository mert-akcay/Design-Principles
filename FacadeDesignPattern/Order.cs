namespace FacadeDesignPattern;

internal class Order
{
    internal Customer customer;
    internal Product product;

    internal Order(Customer customer, Product product)
    {
        this.customer = customer;
        this.product = product;
    }

    internal void PlaceOrder()
    {
        Stock stock = new();
        Payment payment = new();
        Invoice invoice = new();

        Console.WriteLine("Place Order Started");
        stock.CheckStock(product);
        payment.GetPayment(customer);
        invoice.SendInvoice(customer);
        Console.WriteLine("Place Order Completed");
        
    }
}
