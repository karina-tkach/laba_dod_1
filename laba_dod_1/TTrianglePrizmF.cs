using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_dod_1
{
    public class TTrianglePrizmF : TTrianglePrizm
    {
        public TTrianglePrizmF() : base()
        {
        }
        public TTrianglePrizmF(double a, double b, double c, double h) : base(a, b, c, h)
        {
        }
        public override bool Equals(object? obj)
        {
            return obj is TTrianglePrizmF f &&
                   base.Equals(obj) &&
                   Height == f.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), height);
        }
    }
}
