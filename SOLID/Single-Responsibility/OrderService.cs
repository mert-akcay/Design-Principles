namespace SOLID.Single_Responsibility;

internal class OrderService
{
    public void CreateOrder()
    {
        Console.WriteLine("Order Created");
    }
}
public class PaymentService
{
    public void MakePayment()
    {
        Console.WriteLine("Payment Completed");
    }
}
public class InvoiceService
{
    public void CreateInvoice()
    {
        Console.WriteLine("Invoice has Created");
    }
}
public class EmailService
{
    public void SendInvoice()
    {
        Console.WriteLine("Invoice has Sent");
    }
}
