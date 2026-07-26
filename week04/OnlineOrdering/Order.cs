using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateOrderTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }

        double shippingCost = _customer.LivesInUsa() ? 5.00 : 35.00;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"--- Shipping Label ---\n";
        label += $"{_customer.GetName()}\n{_customer.GetAddressString()}\n";
        return label;
    }
}