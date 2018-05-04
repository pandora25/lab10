using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Circule
    {
        private double radius;
        
        // constractor
        public Circule(double radius)
        {
            this.Radius = radius;
        }

        public Circule()
        {
            Radius = 0;
        }

        // propertes 
        public double Radius

        {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }
        }

       // creat  two methods
        public double CalculateCircumference()
        {
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double pi = Math.PI;
            double area = pi * (radius * radius);
            return area;

        }

    }
}
