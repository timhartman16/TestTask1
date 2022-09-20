using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("The length of the side must be a positive number");
            if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Sides do not form a triangle");

            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            var HP = HalfPerimetr();
            return Math.Sqrt(HP * (HP - A) * (HP - B) * (HP - C));
        }

        public bool IsRectangular()
        {
            double[] sides = new double[3] { A, B, C };
            Array.Sort(sides);
            if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2.0))
                return true;
            return false;
        }

        private double Perimetr()
        {
            return (A + B + C);
        }

        private double HalfPerimetr()
        {
            return Perimetr() / 2.0;
        }
    }
}
