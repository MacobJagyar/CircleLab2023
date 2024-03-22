using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab2024
{
    public class circle
    {
        public circle(double aRadius) 
        {
            radius = aRadius;
        }

        public double radius { get; set; }

        public double CalcDiameter()
        {
            return radius * 2;
        }

        public double CalcCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalcArea()
        {
            return Math.PI * (Math.Pow(radius, 2));
        }

        public void Grow()
        {
            radius *= 2;
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
