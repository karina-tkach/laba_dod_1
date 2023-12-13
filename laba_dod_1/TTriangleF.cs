using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_dod_1
{
    public class TTriangleF : TTriangle
    {
        public TTriangleF() : base(1,1,1)
        {
        }
        public TTriangleF(double a, double b, double c) : base(a,b,c)
        {  
        }
        public override bool Equals(object? obj)
        {
            return obj is TTriangleF f &&
                   this.CompareTo((TTriangle)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(a+b+c);
        }
    }
}
