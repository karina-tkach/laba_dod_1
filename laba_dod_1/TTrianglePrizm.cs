using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_dod_1
{
    public class TTrianglePrizm : TTriangleF
    {
        protected double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Некоректне значення висоти призми");
                }
            }
        }
        public TTrianglePrizm() : this(1, 1, 1, 1)
        {
        }
        public TTrianglePrizm(double a, double b, double c, double h) : base(a,b,c)
        {
            Height = h;
        }
        public TTrianglePrizm(TTriangle baseOf, double height) : this(baseOf.A, baseOf.B, baseOf.C, height)
        {
        }
        public TTrianglePrizm(TTrianglePrizm prizm)
        {
            A = prizm.A;
            B = prizm.B;
            C = prizm.C;
            Height = prizm.Height;
        }
        public double Volume()
        {
            return height * base.Area();
        }
        override public string ToString()
        {
            return $"Triangular prizm with base sides: a={a}, b={b}, c={c} and height h={height}";
        }
        //or sum of all sides
        public double PerimeterOfBase()
        {
            return base.Perimeter();
        }
        public new double Area()
        {
            return 2 * base.Area() + base.Perimeter() * height;
        }
        //or static with TTrianglePrizm parametr
        public new void PrintInfo()
        {
            Console.WriteLine($"Sides of triangle base:\na={a}\nb={b}\nc={c}\nHeight: h={height}\nPerimeter of base: {this.PerimeterOfBase()}\nSurface area : {this.Area()}\nVolume:{this.Volume()}");
        }
        //out parametr
        public static TTrianglePrizm EnterInfo()
        {
            Console.WriteLine("Enter first side (а) of base as integer or decimal using comma separator:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side (b) of base as integer or decimal using comma separator:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side (c) of base as integer or decimal using comma separator:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of prizm as integer or decimal using comma separator:");
            double h = Convert.ToDouble(Console.ReadLine());
            return new TTrianglePrizm(a, b, c, h);
        }
        public bool CompareTo(TTrianglePrizm prizm)
        {
            return base.CompareTo(prizm) && this.height == prizm.Height;
        }
        public static TTrianglePrizm operator *(TTrianglePrizm prizm, int value)
        {
            return new TTrianglePrizm { a = prizm.a * value, b = prizm.b * value, c = prizm.c * value, height = prizm.height * value };
        }
        public static TTrianglePrizm operator *(int value, TTrianglePrizm prizm)
        {
            return new TTrianglePrizm { a = prizm.A * value, b = prizm.b * value, c = prizm.c * value, height = prizm.height * value };
        }
    }
}
