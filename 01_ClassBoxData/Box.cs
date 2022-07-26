using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException($"{} cannot be zero or negative.");
                }
                else
                {
                    this.lenght = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }
    }
}
