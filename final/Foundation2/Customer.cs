using System;

public class Customer
{
    private string _name;
    public Address _customerAddress;

    public Customer(string name, Address customerAddress)
    {
        _name = name;
        _customerAddress = customerAddress;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }
}
