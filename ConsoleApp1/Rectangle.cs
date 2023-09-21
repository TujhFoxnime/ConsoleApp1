using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle
    {
        private double side1;
        private double side2;
        public Rectangle(double sideA, double sideB) 
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}
