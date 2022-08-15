using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _04_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough doughType;
        private int toppingCount;
        private double totalCalories;

        public List<Topping> toppingType
        {
            get;
        }

        public Pizza()
        {
            this.toppingType = new List<Topping>();
        }
        public Pizza (string name)
            :this()
        {
            this.Name = name;
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
            set
            {
                this.doughType = value;
            }
        }
        /*public int ToppingCount
        {
            get { return this.toppingCount; }
            private set { this.toppingCount = value; }
        }*/

        /*public double TotalCalories
        {
            get { return this.totalCalories; }
            
            set
            { this.totalCalories = value; }
        }*/

        public void AddTopping(Topping t)
        {
            /*if (toppingType.Count > 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            else
            {
                this.toppingType.Add(t);
                this.TotalCalories += t.CaloriesPerGram;
                this.ToppingCount++;
            }*/
            if(this.toppingType.Count >= 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }

            this.toppingType.Add(t);
        }

        public double PizzaCalories()
        {
            double totalCal = this.toppingType.Sum(t => t.Calories());
            return totalCal + DoughType.Calories();
        }
        public override string ToString()
        {
            return $"{this.Name} - {PizzaCalories():f2} Calories.";
        }

    }
}
