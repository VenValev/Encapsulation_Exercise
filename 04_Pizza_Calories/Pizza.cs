using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _04_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppingType;
        private Dough doughType;
        private int toppingCount;
        private double totalCalories;

        public Pizza()
        {
            this.toppingType = new List<Topping>();
        }
        public Pizza (string name, Dough doughType)
            :this()
        {
            this.Name = name;
            this.DoughType = doughType;
            this.ToppingCount = toppingCount;
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
        public int ToppingCount
        {
            get { return this.toppingCount; }
            private set
            {
                this.toppingCount = toppingType.Count;
            }
        }
        public double TotalCalories
        {
            get { return this.totalCalories; }
            set
            {
                if(this.toppingType.Count == 0)
                {
                    throw new ArgumentException($"Number of toppings should be in range [0..10].");
                }
                this.totalCalories = toppingType.Sum(c => c.Calories());
            }
        }
        public void AddTopping(Topping t)
        {
            if(toppingType.Count > 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            else
                toppingType.Add(t);
        }

        
    }
}
