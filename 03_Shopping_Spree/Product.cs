using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Shopping_Spree
{
    public class Product
    {
        private const double MinPrice = 0;
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.invalidName);
                }

                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < MinPrice)
                {
                    throw new ArgumentException(ExeptionMessages.invalidMoney);
                }

                this.price = value;
            }
        }
    }
}
