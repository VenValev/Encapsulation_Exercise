using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double caloriesPerGram;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.CaloriesPerGram = caloriesPerGram;
        }
        public double CaloriesPerGram
        {
            get { return this.caloriesPerGram; }
            private set { this.caloriesPerGram = 2.0; }
        }
        private string Type
        {
            get { return this.type; }
            set
            {
                if(String.IsNullOrWhiteSpace(value) 
                    || (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }
        private double Weight
        {
            get => this.weight;
            set
            {
                if(value <=0 || value > 50)
                {
                    throw new ArgumentException($"{nameof(this.Type)} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }

        public double Calories() // moje da ser naloji proverka za .toLower
        {
            double tModifier = 0;

            if(this.Type == "Meat")
            {
                tModifier = 1.2;
            }
            if (this.Type == "Veggies")
            {
                tModifier = 0.8;
            }
            if (this.Type == "Cheese")
            {
                tModifier = 1.1;
            }
            if (this.Type == "Sauce")
            {
                tModifier = 0.9;
            }

            return this.CaloriesPerGram * tModifier * this.Weight;
        }

    }
}
