using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Models
{
    public class Celcius
    {
        public double Degree { get; set; }

        public Celcius(double degree)
        {
            Degree=degree;
        }

        public static implicit operator Kelvin(Celcius degree)
        {
            return new Kelvin(degree.Degree+273);
        }
    }
}
