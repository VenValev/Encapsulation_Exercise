using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Shopping_Spree
{
    public class Person
    {
        private string name;
        private double money;
        private List<string> bagOfProducts;

        private Person()
        {
            BagOfProducts = new List<string>();
        }
        public Person(string name, double money)
            : this()
        {
            this.Name = name;
            this.Money = money;
            
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
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

        public List<string> BagOfProducts
        {
            get
            {
                return this.bagOfProducts;
            }
            set
            {
                this.bagOfProducts = value;
            }
        }
        //toString()?
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - ");
            if(BagOfProducts.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                sb.Append(String.Join(", ", BagOfProducts));
            }

            return sb.ToString().Trim();
        }
    }
}
