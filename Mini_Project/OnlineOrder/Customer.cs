namespace OnlineOrder;


public class Customer
{

    public string? drink;
    public string? entree;
    public string? size;

    public Customer()
    {}

    public Customer(string myDrink, string myEntree, string mySize)
    {
        drink = myDrink;
        entree = myEntree;
        size = mySize;
    }

}