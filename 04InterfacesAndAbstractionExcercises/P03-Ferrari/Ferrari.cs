using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public class Ferrari : IFerrari
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public Ferrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }
        public string HitBreaks()
        {
            return "Brakes!";
        }

        public string UseGas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{Model}/{HitBreaks()}/{UseGas()}/{Driver}";
        }
    }
}
