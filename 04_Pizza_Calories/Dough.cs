using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Dough
    {
        private const string errMsgDough = "Invalid type of dough.";
        private const string errMsgWeight = "Dough weight should be in the range [1..200].";
        private string dType;
        private string dBake;
        private double caloriesPerGram;
        private double dWeight;
        

        public Dough(string dType,string dBake, double dWeight)
        {
            this.DType = dType;
            this.DBake = dBake;
            this.DWeight = dWeight;
            this.CaloriesPerGram = this.caloriesPerGram;
        }

        private string DType
        {
            get { return this.dType; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(errMsgDough);
                }
                else if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(errMsgDough);
                }
                else
                {
                    this.dType = value.ToLower();
                }
            }
        }
        private string DBake
        {
            get
            {
                return this.dBake;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value) 
                    || (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade"))
                {
                    throw new ArgumentException(errMsgDough);
                }
                else
                {
                    this.dBake = value.ToLower();
                }
            }
        }
        private double DWeight
        {
            get
            {
                return this.dWeight;
            }
            set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException(errMsgWeight);
                }

                this.dWeight = value;
            }
        }
        public double CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
            private set
            {
                this.caloriesPerGram = 2.0;
            }
        }

        public double Calories()
        {
            double dModifier;
            double bModifier;

            if(DType == "white")
            {
                dModifier = 1.5;
            }
            else  // proveri dali minava prez proverki
            {
                dModifier = 1.0;
            }
            if(DBake == "crispy")
            {
                bModifier = 0.9;
            }
            else if(DBake == "chewy")
            {
                bModifier = 1.1;
            }
            else
            {
                bModifier = 1.0;
            }

            return (CaloriesPerGram * DWeight) * dModifier * bModifier;
        }

    }
}
