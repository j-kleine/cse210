using System;

public class Customer
{
    public string Name { get; }
    public Address CustomerAddress { get; }

    public Customer(string name, Address customerAddress)
    {
        Name = name;
        CustomerAddress = customerAddress;
    }

    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}
