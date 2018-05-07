using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Circule
    {
        //create a variable 
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
        public string CalculateFormattedeCircumference()
        {
            string formated = $"{CalculateCircumference(),0:N2}";
            return formated;
        }
        //3.
        public double CalculateArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
        //4.
        public string CalculateFormattedArea()
        {
            string formated = $"{CalculateArea(),0:N2}";
            return formated;
        }
    }
}
