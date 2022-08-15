using System;

namespace _04_Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            Dough dough;

            try
            {
                string[] pizzaLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                pizza = new Pizza(pizzaLine[1]);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            try
            {
                string[] doughLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                dough = new Dough(doughLine[1], doughLine[2], double.Parse(doughLine[3]));
                pizza.DoughType = dough;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string command;
                
             
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmndArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(cmndArg[1], double.Parse(cmndArg[2]));
                    pizza.AddTopping(topping);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }

            }
            
            Console.WriteLine(pizza.ToString());

            

        }
    }
}
