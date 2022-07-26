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
        private const int boxMinValue = 0;
        private const string ZeroNegativeError = "{0} cannot be zero or negative.";

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
                if(value <= boxMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroNegativeError, nameof(this.Lenght)));
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
                if (value <= boxMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroNegativeError, nameof(this.Width)));
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
                if (value <= boxMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroNegativeError, nameof(this.Height)));
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public double SurfaceArea()
        {
            return 0;
        }

        public double LatheralSurfaceArea()
        {
            return 0;
        }

        public double Volume()
        {
            return 0;
        }
    }
}
