using System;

namespace _04_Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] doughLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dough dough = new Dough(doughLine[1], doughLine[2], double.Parse(doughLine[3]));
            Pizza pizza = new Pizza(pizzaLine[1], dough);
            string command;

            try
            {
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmndArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(cmndArg[1], double.Parse(cmndArg[2]));
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }



        }
    }
}
