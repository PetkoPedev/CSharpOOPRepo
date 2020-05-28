using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
        public double SideA
        {
            get { return this.sideA; }
            private set { this.sideA = value; }
        }

        public double SideB
        {
            get { return this.sideB; }
            private set { this.sideB = value; }
        }

        public override double CalculateArea()
        {
            return this.sideA * this.sideB;
        }

        public override double CalculatePerimeter()
        {
            return this.sideA * 2 + this.sideB * 2;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
