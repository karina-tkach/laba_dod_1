using laba_dod_1;

namespace PrizmAndTriangleTests
{
    public class OperatorOverloadingTests
    {
        [Fact]
        public void TTriangleMultiplication()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle1 = triangle * 5;
            Assert.True(triangle1.A == 15 && triangle1.B == 20 && triangle1.C == 25);
        }

        [Fact]
        public void TTriangleMultiplicationReverse()
        {
            TTriangle triangle = new (3, 4, 5);
            TTriangle triangle1 = 5 * triangle;
            Assert.True(triangle1.A == 15 && triangle1.B == 20 && triangle1.C == 25);
        }

        [Fact]
        public void TTrianglePrizmMultiplication()
        {
            TTrianglePrizm prizm = new (6, 8, 10, 2);
            TTrianglePrizm prizm1 = prizm * 2;
            Assert.True(prizm1.A == 12 && prizm1.B == 16 && prizm1.C == 20 && prizm1.Height == 4);
        }

        [Fact]
        public void TTrianglePrizmMultiplicationReverse()
        {
            TTrianglePrizm prizm = new (6, 8, 10, 2);
            TTrianglePrizm prizm1 = 2 * prizm;
            Assert.True(prizm1.A == 12 && prizm1.B == 16 && prizm1.C == 20 && prizm1.Height == 4);
        }
    }
}
