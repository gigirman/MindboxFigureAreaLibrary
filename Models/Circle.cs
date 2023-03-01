using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxFigureAreaLibrary
{
    public class Circle : IFigureAreaService
    {
        public Circle(double r)
        {
            if (r < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }
            else
            {
                R = r;
            }            
        }

        public double R { get; set; }
        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
