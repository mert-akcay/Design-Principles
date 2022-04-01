using FacadeDesignPattern;

Product product = new("Television");
Customer customer = new("Mert Akcay");

Order order = new(customer,product);

order.PlaceOrder();