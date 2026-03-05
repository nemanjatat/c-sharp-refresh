using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // overloaded constructors = technique to create multiple constructors
        //                           with a different set of parameters
        //                           name + parameters = signature

        Pizza pizza1 = new Pizza("thin crust", "tomato basil", "mozzarella", "pepperoni");
        Pizza pizza2 = new Pizza("stuffed crust", "garlic white", "cheddar");
        Pizza pizza3 = new Pizza("whole weat", "classic tomato");
        Pizza pizza4 = new Pizza("regular crust");

        pizza1.CustomerOrderInfo();
        pizza2.CustomerOrderInfo();
        pizza3.CustomerOrderInfo();
        pizza4.CustomerOrderInfo();

        Console.ReadKey();
    }
}