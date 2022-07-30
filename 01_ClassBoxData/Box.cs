using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ClassBoxData
{
    public class Box
    {
        private const int boxMinValue = 0;
        private const string ZeroNegativeError = "{0} cannot be zero or negative.";
        private double lenght;
        private double width;
        private double height;
        

        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                if(value <= boxMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroNegativeError, nameof(this.Length)));
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
            return (2*this.Length * this.Width) + (2*this.Width*this.Height) + (2*this.Length * this.Height);
        }

        public double LateralSurfaceArea()
            => (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        public double Volume()
            => this.Length * this.Width * this.Height;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");
            return sb.ToString();
        }
    }
}
