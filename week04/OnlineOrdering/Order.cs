using System;
using System.Collections.Generic;


public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer Customer, Product Product)
    {
        _customer = Customer;
        _products = new List<Product>();
        _products.Add(Product);
    }
    public void AddProduct(Product Product)
    {
        if (_products == null) _products = new List<Product>();
        _products.Add(Product);
    }

    public double CalculateTotalCost()
    {

        double total = 0.0;

        if (_customer != null && _customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        foreach (var product in _products)
        {
            total += product.ProductTotalCost();
        }
        return Math.Round(total,2);
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("----Packing Label----");
        int number = 1;
        foreach (var product in _products)
        {
            Console.WriteLine($"Product {number}\n  Name: {product.GetProductName()}\n  Id: {product.GetProductId()}");
            number += 1;
        }
        Console.WriteLine($"Total cost is: ${CalculateTotalCost()}\n");
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"----Shipping Label----\nCC: {_customer.GetCustomerName()}\nTo: {_customer.GetAddress()}\n");
    }
}