using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpace;

namespace ConsoleApp1
{
    public class Circle : IFigure
    { const double PI = Math.PI;
        private double _area;
        private double _radius;

        public double Area
        {
            get => PI * Math.Pow(_radius, 2);
     
        }
        public double Radius
        {
            get  => _radius;
            set
            {
                if (value <= 0) throw new ArgumentException();
                _radius = value;
            }
        }

        public Circle(double r) => _radius = r;

        public void Print()
        {
            Console.WriteLine(Area);
        }
    }

}
