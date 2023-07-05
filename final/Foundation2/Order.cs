using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; }
    private Customer Customer { get; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.CalculatePrice();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label:\nCustomer: {Customer.Name}\n\nProduct (ID) | Price x Quantity:\n";
        foreach (Product product in Products)
        {
            label += $"> {product.Name} ({product.ProductId}) | {product.Price} x {product.Quantity}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        //return $"Shipping Label:\n- Customer: {Customer.Name}\nAddress:\n{Customer.CustomerAddress.GetAddressAsString()}";
        return $"Shipping Label:\n\n{Customer.Name}\n{Customer.CustomerAddress.GetAddressAsString()}";

    }
}
