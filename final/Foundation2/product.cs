public class Product
{
    private int _productid;
    private int _price;
    private int _quantity;


    public Product(int id, int price, int quantity){
        _productid = id;
        _price = price;
        _quantity = quantity;
    }

    public int ComputeCost(){
        return _price * _quantity;
    }
    public string GetProduct(){
        return $"{_productid} - {_price}$ ({_quantity})";
    }
}