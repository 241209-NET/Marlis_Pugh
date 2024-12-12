using System.Collections.Generic;

namespace OnlineOrder;

public class Utilities
{

    List<Customer> OrderDetails = [];

    public void ShowMenu()
    {

        string itemOne = "Combo One includes the Chicken Sandwhich with side and drink";
        string itemTwo = "Combo Two includes the Burger with side and drink";
        string itemThree = "Combo Three includes the Fish Sandwhich with side and drink";

        List<string> Options = [];
        Options.Add(itemOne);
        Options.Add(itemTwo);
        Options.Add(itemThree);

        foreach(string yourSelection in Options) 
        {
            Console.WriteLine(yourSelection);
        }

    }

    public void PlaceOrder() 
    {

            List<Customer> orderDetails = [];
        
        Console.WriteLine("Select your drink: Sprite, Tea, M-Dew: MAKE SURE YOUR DRINK SELECTION IS SPELLED CORRECT THANKS!");
            string drinkOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your entree: Chicken Sand, Burger, Fish Sand: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string entreeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your drink: SM, MD, LG: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string sizeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("You selected: " + drinkOption + "-" + entreeOption + "-" + sizeOption);
             Console.WriteLine("If this is correct press Y for yes or N for no Thanks");
             string correctOrder = Console.ReadLine();
             Console.WriteLine("----------------------------------------------------------------------------------");
            if(correctOrder == "Y") {
            Customer currentOrder = new Customer(drinkOption, entreeOption, sizeOption);
            orderDetails.Add(currentOrder);
            } else if (correctOrder == "N") {
            Console.WriteLine("Please renter selction");
            } else {
            Console.WriteLine("Thanks for coming");
            }

    }

    public void OrderConfirmation()
    {
    



    }












}