using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Shopping_Spree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.invalidName);
                }

                this.name = value;
            }
        }
        public double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessages.invalidMoney);
                }

                this.money = value;
            }
        }
    }
}
