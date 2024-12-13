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
            int num = 0;
        
        Console.WriteLine("Select your drink: Sprite, Tea, M-Dew: MAKE SURE YOUR DRINK SELECTION IS SPELLED CORRECT THANKS!");
            string? drinkOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your entree: Chicken Sand, Burger, Fish Sand: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string? entreeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your drink: SM, MD, LG: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string? sizeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("You selected: " + drinkOption + "-" + entreeOption + "-" + sizeOption);
             Console.WriteLine("If this is correct press Y for yes or N for no Thanks");
             string? correctOrder = Console.ReadLine();
             Console.WriteLine("----------------------------------------------------------------------------------");
            if(correctOrder == "Y") {
            Customer? currentOrder = new Customer(drinkOption!, entreeOption!, sizeOption!);
            orderDetails.Add(currentOrder);
            } else if (correctOrder == "N") {
            Console.WriteLine("Please re-enter selection");
            ShowMenu();
            PlaceOrderOne();
            
            } else {
            Console.WriteLine("Thanks for coming");
            }

            Console.WriteLine("Your total is: ");
            Console.WriteLine("----------------------------------------------------------------------------------");

            if(entreeOption == "Chicken Sand") 
                num = 1;
                else if(entreeOption == "Burger")
                num = 2;
                else 
                {
                num = 3;
                }

                switch(num) {

                    case 1:
                Console.WriteLine("Combo price is $15.99");
                    break;

                        case 2:
                Console.WriteLine("Combo price is $13.99");
                    break;

                    case 3:
                Console.WriteLine("Combo price is $15.99");
                break;

                default:
                Console.WriteLine("Exit Program");
                break;

                    }

                    double itemPrice1 = 13.99;
                    double itemPrice = 15.99;
                    double tax = 3.99;
                    double totalPrice = tax + itemPrice;
                    double totalPrice1 = tax + itemPrice1;

                Console.WriteLine("Your total plus tax is: ");
                    if(num == 1)
                    Console.WriteLine(totalPrice);
                    else if (num == 2)
                Console.WriteLine(totalPrice1);
                    else if (num == 3)
                Console.WriteLine(totalPrice);
                        else
                Console.WriteLine("Thanks for coming");
                Console.WriteLine("----------------------------------------------------------------------------------");

                foreach(Customer reciept in orderDetails)
                        {
                    Console.WriteLine("Your Order Included: ");
                    Console.WriteLine("Drink selection: " + reciept.drink + "Protein selection: " + reciept.entree + "Combo Size selection: " + reciept.size);
                         }
                         Console.WriteLine("----------------------------------------------------------------------------------");
    

    }

    public void PlaceOrderOne() 
    {

            List<Customer> orderDetails = [];
            
        
        Console.WriteLine("Select your drink: Sprite, Tea, M-Dew: MAKE SURE YOUR DRINK SELECTION IS SPELLED CORRECT THANKS!");
            string? drinkOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your entree: Chicken Sand, Burger, Fish Sand: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string? entreeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Select your drink: SM, MD, LG: MAKE SURE YOUR SELECTION IS SPELLED CORRECT THANKS!");
            string? sizeOption = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("You selected: " + drinkOption + "-" + entreeOption + "-" + sizeOption);
             Console.WriteLine("If this is correct press Y for yes or N for no Thanks");
             string? correctOrder = Console.ReadLine();
             Console.WriteLine("----------------------------------------------------------------------------------");
            if(correctOrder == "Y") {
            Customer? currentOrder = new Customer(drinkOption!, entreeOption!, sizeOption!);
            orderDetails.Add(currentOrder);
            } else if (correctOrder == "N") {
            Console.WriteLine("Please re-enter selection");
            ShowMenu();
            PlaceOrderOne();
            
            } else {
            Console.WriteLine("Thanks for coming");
            }
    

    }

    public void OrderConfirmation()
    {
    



    }












}