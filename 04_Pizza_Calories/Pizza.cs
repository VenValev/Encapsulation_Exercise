using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppingType;
        private Dough doughType;
        private int toppingCount;
        private int totalCalories;

        public Pizza()
        {
            toppingType = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.name = value;
            }
        }
    }
}
