public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;


    }
    public bool USResident(){
        return _address.IsUSResident();
    }
    public void GetCustomer(){
        System.Console.WriteLine(_name);
        System.Console.WriteLine(_address.GetAddress());
    }
}