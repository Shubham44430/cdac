using System;
using Shop;

class Program
{

    public static void Main()
    {
        Item a = new Item();
        a.id = 1;
        a.Costperunit = 20;
        a.Quantity = 20;
        Console.WriteLine("Your bill amount is : {0:0.00}", a.SellingPrice());

        ShoppingCart b = new ShoppingCart(2, 250, 250);
        Console.WriteLine("Your bill amount is : {0:0.00}", b.SellingPrice());
    }
}