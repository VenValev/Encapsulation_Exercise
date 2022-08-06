using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Dough
    {
        private const string errMsg = "Invalid type of dough.";
        private string dType;
        private string dBake;
        private const double caloriesPerGram = 2;
        private double dWeight;

        public string DType
        {
            get { return this.dType; }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(errMsg);
                }
                else if(value != "White" || value != "Wholegrain")
                {
                    throw new ArgumentException(errMsg);
                }
                else
                {
                    this.dType = value;
                }
            }
        }
        public string DBake
        {
            get
            {
                return this.dBake;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value) || value != "Crispy" || value != "Chewy" || value != "Homemade")
                {
                    throw new ArgumentException(errMsg);
                }
                else
                {
                    this.dBake = value;
                }
            }
        }
    }
}
