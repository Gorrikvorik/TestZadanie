using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpace;

namespace ConsoleApp1
{
    public class Triangle : IFigure
    { 
        public double Area
        {
            get
            {
                return Math.Sqrt(p * (p - s[0])*(p - s[1]) * (p - s[2]));
            }
        }

       
        private double p;
        public double[] s { get; set; }
        public Triangle(double[] sides)
        {
            foreach (var s in sides) if (s <= 0) throw new ArgumentException();
            s = sides;
            p = (sides[0] + sides[1] + sides[2]) / 2;

        }

        public void Print()
        {
            Console.WriteLine(Area);
        }
    }
}
