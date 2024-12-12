namespace OnlineOrder;

class Program
{

        



    static void Main(string[] args)
    {
        Utilities u = new Utilities();


            Console.WriteLine("**************************************************");
            Console.WriteLine("WELCOME TO ONLINE ONTIME ALL THE TIME FOOD SERVICE");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("__________________________________________________");

            u.ShowMenu();
            u.PlaceOrder();
            u.OrderConfirmation();


    }
}
