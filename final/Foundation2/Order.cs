class Order
{
  List<Product> _products = new List<Product>();
  Customer _customer = new Customer();

  public Order(List<Product> products, Customer customer)
  {
    _customer = customer;
    _products = products;
  }

  public double GetTotalCost()
  {
    double cost = 0.0;
    foreach (Product product in _products)
    {
      cost = cost + product.GetProductPrice();
    }
    if (_customer.GetInUsa()) return cost + 5;   // if in the USA adds 5 for shipping
    else return cost + 35;                       // otherwise it adds 35 for shipping
  }

  public string GetPackingLabel()
  {
    string packingLabel = "";
    foreach (Product product in _products)
    {
      packingLabel = packingLabel + $"{product.GetProductName()} - {product.GetProductId()}\n";
    }
    return packingLabel;
  }

  public string GetShippingLabel()
  {
    return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
  }
}