using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laba_dod_1
{
    public class TTriangle
    {
        protected double a;
        protected double b;
        protected double c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect value of triangle's side");
                }
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect value of triangle's side");
                }
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect value of triangle's side");
                }
            }
        }
        public TTriangle() : this(1, 1, 1)
        {
        }
        public TTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("Triangle does not exist");
            }
        }
        public TTriangle(TTriangle triangle)
        {
            A = triangle.a;
            B = triangle.b;
            C = triangle.c;
        }
        override public string ToString()
        {
            return $"Triangle with sides: a={a}, b={b}, c={c}";
        }        public double Perimeter()
        {
            return (a + b + c);
        }
        public double Area()
        {
            double halfPerimeter = this.Perimeter() / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - this.a) * (halfPerimeter - this.b) * (halfPerimeter - this.c));
            return area;
        }        //or static with TTriangle parametr
        public void PrintInfo()
        {
            Console.WriteLine($"Side a: {a}\nSide b: {b}\nSide c: {c}\nTriangle's perimeter: {this.Perimeter()}\nTriangle's area: {this.Area()}");
        }
        //out parametr
        public static TTriangle EnterInfo()
        {
            Console.WriteLine("Enter first side (а) as integer or decimal using comma separator:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side (b) as integer or decimal using comma separator:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side (c) as integer or decimal using comma separator:");
            double c = Convert.ToDouble(Console.ReadLine());
            return new TTriangle(a, b, c);
        }
        public bool CompareTo(TTriangle triangle)
        {
            double[] sidesOfFirstTriangle = new[] { a, b, c };
            Array.Sort(sidesOfFirstTriangle);
            double[] sidesOfSecondTriangle = new [] { triangle.A, triangle.B, triangle.C };
            Array.Sort(sidesOfSecondTriangle);
            bool areEqual = Enumerable.SequenceEqual(sidesOfFirstTriangle, sidesOfSecondTriangle);
            return areEqual;
        }
        public static TTriangle operator *(TTriangle triangle, int value)
        {
            return new TTriangle { a = triangle.a * value, b = triangle.b * value, c = triangle.c * value };
        }
        public static TTriangle operator *(int value, TTriangle triangle)
        {
            return new TTriangle { a = triangle.a * value, b = triangle.b * value, c = triangle.c * value };
        }
    }
}
