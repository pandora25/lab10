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
       //1.
        public double CalculateCircumference()
        {
            double circumference = Math.PI * 2 * radius;
            return circumference;
        }
        //2.
        public double CalculateArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
    }
}
