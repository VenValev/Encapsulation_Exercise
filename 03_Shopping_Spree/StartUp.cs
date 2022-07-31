using System;
using System.Collections.Generic;

namespace _03_Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string command;
            List<Person> listOfPeople = new List<Person>();
            List<Product> listOfProducts = new List<Product>();
            try
            {
                for (int i = 0; i < people.Length; i++)
                {
                    string[] pplsArg = people[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string pName = pplsArg[0];
                    double pMoney = double.Parse(pplsArg[1]);
                    Person person = new Person(pName, pMoney);
                    listOfPeople.Add(person);
                }

                for(int i = 0; i < products.Length; i++)
                {
                    string productName = products[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[0];
                    double price = double.Parse(products[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[0]);
                    Product product = new Product(productName, price);
                    listOfProducts.Add(product);
                }

                while ((command = Console.ReadLine()) != "END")
                {

                }
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
    }
}
