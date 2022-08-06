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
            get { return dType; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {

                }
            }
        }

    }
}
