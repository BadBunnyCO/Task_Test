using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public static class Square
    {
        static public double SomeFigure(double a, double b, double c)
        {
            return Triangle(a, b, c);
        }

        static public double SomeFigure(double r)
        {
            return Circle(r);
        }
        static public double Circle(double r)
        {
            return Math.Round(Math.PI * r * r,2);
        }
        static public double Triangle(double a, double b, double c)
        {
            if (a * a == b * b + c * c)
            {
                return b * c / 2;
            }
            else if (b*b== a*a + c*c)
            {
                return a * c / 2;
            } 
            else if(c*c == a * a + b * b)
            {
                return b * a / 2;
            }
            else {
                double p = (a + b + c) / 2;
                return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2);
            }
        }
    }
}
