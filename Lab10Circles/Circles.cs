using System;
using System.Collections.Generic;
using System.Text;


namespace Lab10Circles
{
    class Circles
    {
        private double Radius;

        public Circles(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateCircumference()
        {
           return 2 * Radius * Math.PI;
        }
        
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(2*Radius*Math.PI);
        }
        public double CalculateArea()
        {
            return Math.PI *Radius * Radius;
        }
        public string CalculateFormattedArea()
        {
           return FormatNumber(Math.PI * Radius * Radius);
        }
        private string FormatNumber(double x)
        {
           return x.ToString("#.00");
        }
        //public const double PI= Math.PI;



        public double GetRadius()
        {
            return Radius;
        }
    }
}
