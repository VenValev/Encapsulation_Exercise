using System;

namespace _04_Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string cmnd;

            while((cmnd = Console.ReadLine()) != "END")
            {
                string[] cmndArg = cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (cmndArg[0] == "Dough")
                    {
                        Dough dd = new Dough(cmndArg[1], cmndArg[2], double.Parse(cmndArg[3]));
                        Console.WriteLine($"{dd.Calories():f2}");
                    }
                    else if (cmndArg[0] == "Topping")
                    {
                        Topping dd = new Topping(cmndArg[1], double.Parse(cmndArg[2]));
                        Console.WriteLine($"{dd.Calories():f2}");
                    }
                    
                    //Console.WriteLine(dd.CaloriesPerGram);
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                
            }
        }
    }
}
