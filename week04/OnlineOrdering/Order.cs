public class Order 
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _product = products;
        _customer = customer;
    }
    
    public double CalcTotalCost()
    {
        double productsPrice = 0;
        foreach (Product product in _product)
        {
            productsPrice += product.CalcTotalCost();
        }
        // add shipping cost on customer location
        double shippingCost;
        if (_customer.LivesInUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return productsPrice + shippingCost;
        
    }


    public void GetPackingLabel()
    {
        foreach (Product product in _product)
        {
            Console.WriteLine(product.GetNameAndID());
        }
    }

    public void GetshippingLabel()
    {
        Console.WriteLine(_customer.getNameAndAddress());
    }



}
