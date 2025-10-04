using System;

class Program
{
    static void Main(string[] args)
    {

        Address _firstaddress = new Address("Simon Bolivar 30", "Naucalpan", "Estado de México", "México");
        Customer _firstcustomer = new Customer("Samuel Sandoval", _firstaddress);

        Product _1cProduct1 = new Product("Leche", 12345, 26.50, 3);
        Product _1cProduct2 = new Product("Pan", 54321, 30.21, 2);

        Order _order1 = new Order(_firstcustomer, _1cProduct1);
        _order1.AddProduct(_1cProduct2);

        Address _secondaddress = new Address("Maestro Larroyo 5", "Gustavo A Madero", "Ciudad de México", "México");
        Customer _secondcustomer = new Customer("Ashley Ruiz", _secondaddress);

        Product _2cProduct1 = new Product("Gelisgh", 9876, 12.10, 5);
        Product _2cProduct2 = new Product("Lampara", 6789, 80.90, 1);
        Product _2cProduct3 = new Product("Labial", 9687, 16.50, 2);

        Order _order2 = new Order(_secondcustomer, _2cProduct1);
        _order2.AddProduct(_2cProduct2);
        _order2.AddProduct(_2cProduct3);

        _order1.DisplayShippingLabel();
        _order1.DisplayPackingLabel();

        _order2.DisplayShippingLabel();
        _order2.DisplayPackingLabel();
          

    }
}