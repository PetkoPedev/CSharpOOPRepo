using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public interface IFerrari
    {
        string Model { get; set; }
        string Driver { get; set; }
        string HitBreaks();
        string UseGas();
    }
}
