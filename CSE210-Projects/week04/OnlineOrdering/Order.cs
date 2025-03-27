public class Order
{
    private List<Product>_products=new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer=customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total=0;
        foreach(var product in _products)
        {
            total+=product.GetTotalCost();
        }

        double ShippingCost= _customer.LivesInUsa() ?  5 :35;
        return total+=ShippingCost;
    }

    public string GetPackingLabel()
    {
        string label="packing List:\n";
        foreach(var product in _products)
        {
            label+=product.GetPackingLabel() + "\n";

        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping to:\n" + _customer.GetShippingLabel();
    }


}