﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double caloriesPerGram;
        private double weight;
        private double tModifier = 0;
        private const double deffaultModifier = 2.0;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.CaloriesPerGram = Calories();
        }
       
        public string Type
        {
            get { return this.type; }
            private set
            {
                if(String.IsNullOrWhiteSpace(value) 
                    || (value.ToLower() != "meat" && value.ToLower() != "veggies" 
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }
        public double CaloriesPerGram
        {
            get { return this.caloriesPerGram; }
            private set { this.caloriesPerGram = value; }
        }

        public double Calories() // moje da ser naloji proverka za .toLower
        {
            if(this.Type.ToLower() == "meat")
            {
                tModifier = 1.2;
            }
            if (this.Type.ToLower() == "veggies")
            {
                tModifier = 0.8;
            }
            if (this.Type.ToLower() == "cheese")
            {
                tModifier = 1.1;
            }
            if (this.Type.ToLower() == "sauce")
            {
                tModifier = 0.9;
            }

            return deffaultModifier * tModifier * this.Weight;
        }

    }
}
