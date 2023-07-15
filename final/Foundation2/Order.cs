using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.CalculatePrice();
        }

        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label:\nCustomer: {_customer.GetName()}\n\nProduct (ID) | Price x Quantity:\n";
        foreach (Product product in _products)
        {
            label += $"> {product.GetName()} ({product.GetProductId()}) | {product.GetPrice()} x {product.GetQuantity()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        //return $"Shipping Label:\n- Customer: {Customer.Name}\nAddress:\n{Customer.CustomerAddress.GetAddressAsString()}";
        return $"Shipping Label:\n\n{_customer.GetName()}\n{_customer._customerAddress.GetAddressAsString()}";

    }
}
