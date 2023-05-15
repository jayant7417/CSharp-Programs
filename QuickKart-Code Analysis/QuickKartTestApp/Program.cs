using System;
class Cart
{
    public string[] items;
    public Cart()
    {
        items = new string[3];
        items[0] = "Apple Iphone 7s";
        items[1] = "Samsung Galaxy 6s";
        items[2] = "xiaomi redmi note 4";
    }
    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main()
    {
        Cart cart = new Cart();
        cart.DisplayItems();
        Console.ReadKey();
    }
}
