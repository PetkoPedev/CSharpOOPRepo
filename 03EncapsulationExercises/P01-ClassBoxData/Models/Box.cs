﻿using System;
using System.Collections.Generic;
using System.Text;
using P01_ClassBoxData.Exceptions;

namespace P01_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.LengthZeroOrNegativeException);
                }
                this.length = value;
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
                    throw new ArgumentException(ExceptionMessages.WidthZeroOrNEgativeException);
                }
                this.width = value;
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
                    throw new ArgumentException(ExceptionMessages.HeightZeroOrNEgativeException);
                }
                this.height = value;
            }
        }
        public double LateralSurfaceArea()
        {
            double result = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
            return result;
        }

        public double SurfaceArea()
        {
            double result = (2 * this.Length * this.Width) + this.LateralSurfaceArea();
            return result;
        }
        
        public double Volume()
        {
            double result = this.Length * this.Width * this.Height;
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {this.Volume():F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
