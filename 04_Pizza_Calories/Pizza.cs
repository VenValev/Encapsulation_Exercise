using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppingType;
        private Dough doughType;
        private int toppingCount;
        private int totalCalories;

        public Pizza()
        {
            this.toppingType = new List<Topping>();
        }
        public Pizza (string name, Dough doughType)
            :this()
        {
            this.Name = name;
            this.DoughType = doughType;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(String.IsNullOrWhiteSpace(value) || (value.Length < 1 || value.Length > 15))
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough DoughType
        {
            get => this.doughType;
            private set
            {
                this.doughType = value;
            }
        }

        
        public void AddTopping(Topping t)
        {
            toppingType.Add(t);
        }
    }
}
