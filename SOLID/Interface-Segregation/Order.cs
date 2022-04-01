namespace SOLID.Interface_Segregation;

internal class Order
{
    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void CCProcess();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            Console.WriteLine("Added to Cart");
        }

        public void CCProcess()
        {
            Console.WriteLine("Credit Card Process Successfull.");
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            Console.WriteLine("Added to Cart");
        }
    }
}
