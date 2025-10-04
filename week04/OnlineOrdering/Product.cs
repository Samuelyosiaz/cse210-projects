using System;

public class Product
{
    private string _pname;
    private int _productId;
    private double _price;
    private int _quantity;
    public Product(string pname, int productId, double price, int quantity)
    {
        _pname = pname;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double ProductTotalCost()
    {
        double ProductTotalCost = _price * _quantity;
        return ProductTotalCost;
    }
    public string GetProductName()
    {
        return _pname;
    }
    public int GetProductId()
    {
        return _productId;
    }
}