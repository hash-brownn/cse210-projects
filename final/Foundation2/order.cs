public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }
    public void SetProducts(Product product){
        _products.Add(product);
    }
    public int TotalPrice(){
        int price = 0;
        foreach(Product product in _products){
            price += product.ComputeCost();
        }   
        return price;
    }
    public void GetShippingLabel(){
        _customer.GetCustomer();
        System.Console.WriteLine("_______________");
        System.Console.WriteLine("Products");
        System.Console.WriteLine("_______________");
        foreach(Product p in _products){
            System.Console.WriteLine(p.GetProduct());
        }
        System.Console.WriteLine($"Total Price: {TotalPrice()}");

    }

}