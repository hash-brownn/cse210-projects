using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("David", new Address("384 Issac Circles", "East Westleyfort", "Nevada", "US"));
        Product p1 = new Product(001, 25, 3);
        Product p2 = new Product(059, 3, 23);
        Product p3 = new Product(011, 20, 2);

        Order order = new Order(customer);
        order.SetProducts(p1);
        order.SetProducts(p2);
        order.SetProducts(p3);
        order.GetShippingLabel();
        
    }
}