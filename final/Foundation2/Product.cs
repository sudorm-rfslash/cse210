class Product
{
  private string _name;
  private string _productId;
  private double _price;
  private int _quantity;

  public Product(string name, string id, double price, int quantity)
  {
    _name = name;
    _productId = id;
    _price = price;
    _quantity = quantity;
  }

  public double GetProductPrice()
  {
    return _price * _quantity;
  }

  public string GetProductName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _productId;
  }
}