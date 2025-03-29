public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double CalcTotalCost()
    {
        double amount = _price * _quantity;
        return amount;
    }
    public string GetNameAndID()
    {
        return $"{_name}: {_productID}";
    }
}