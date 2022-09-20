using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Circle : IFigure
    {
        public double Rad { get; private set; }

        public Circle(double rad)
        {
            if (rad < 0)
                throw new ArgumentException("Invalid radius");
            Rad = rad;
        }

        public double Square()
        {
            return Math.PI * Rad * Rad;
        }
    }
}
