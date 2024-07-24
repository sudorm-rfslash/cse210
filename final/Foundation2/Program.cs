using System;

class Program
{
  static void Main(string[] args)
  {
    //create products
    Product apple = new Product("Apple", "564738", 2.18, 3);
    Product banana = new Product("Banana", "291847", 3.71, 10);
    Product orange = new Product("Orange", "730291", 3.60, 1);
    Product strawberry = new Product("Strawberry", "849302", 3.60, 5);
    Product watermelon = new Product("Watermelon", "405672", 3.60, 7);
    Product mango = new Product("Mango", "918273", 3.60, 9);

    //create address & customer
    Address stevesHouse = new Address("1234 Long Road Drive", "Summerville", "Utah", "USA");
    Customer steve = new Customer("Steve Russell", stevesHouse);

    Address jeffsHouse = new Address("5678 Short Street Cirlce", "Winterville", "Alberta", "Canada");
    Customer jeff = new Customer("Jeff Redford", jeffsHouse);

    //create order using customer and products
    List<Product> stevesCart = new List<Product> { apple, banana, orange };
    Order stevesOrder = new Order(stevesCart, steve);

    List<Product> jeffsCart = new List<Product> { strawberry, watermelon, mango };
    Order jeffsOrder = new Order(jeffsCart, jeff);

    //neatly print objects
    Console.WriteLine(stevesOrder.GetShippingLabel());
    Console.WriteLine("");
    Console.WriteLine(stevesOrder.GetPackingLabel());
    Console.WriteLine($"Order Cost: ${stevesOrder.GetTotalCost()}");

    Console.WriteLine("-----------------------------------");

    Console.WriteLine(jeffsOrder.GetShippingLabel());
    Console.WriteLine("");
    Console.WriteLine(jeffsOrder.GetPackingLabel());
    Console.WriteLine($"Order Cost: ${jeffsOrder.GetTotalCost()}");
  }
}