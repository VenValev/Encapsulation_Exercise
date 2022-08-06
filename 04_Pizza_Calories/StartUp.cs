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
                    Dough dd = new Dough(cmndArg[1], cmndArg[2], double.Parse(cmndArg[3]));
                    Console.WriteLine($"{dd.Calories():f2}");
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                
            }
        }
    }
}
