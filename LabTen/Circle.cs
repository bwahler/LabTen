using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Circle
    {
        private double radius;
        public double PI = Math.PI;

        public Circle(double radius)
        {
           this.radius = radius;
        }
        public double CalculateCircumference()
        {
            double circumference = PI * (2 * radius);
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            double area = PI * (radius * radius);
            return area;
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }
    }
}
