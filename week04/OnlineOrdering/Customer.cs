using System;

public class Customer
{
    private string _cname;
    private Address _address;

    public Customer(string cname, Address Address)
    {
        _cname = cname;
        _address = Address;
    }
    public bool IsInUsa()
    {
        string _country = _address.GetCountry().ToLower();
        string capitalized = char.ToUpper(_country[0]) + _country.Substring(1);
        if (capitalized == "Usa" || capitalized == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string GetCustomerName()
    {
        return _cname;
    }
    public string GetAddress()
    {
        return _address.GetAdress();
    }
}