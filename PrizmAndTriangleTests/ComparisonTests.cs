using laba_dod_1;

namespace PrizmAndTriangleTests
{
    public class ComparisonTests
    {
        [Fact]
        public void TTriangleCompareTo()
        {
            TTriangle triangle = new (3, 4, 5);
            TTriangle triangle2 = new (5, 3, 4);
            var actual = triangle.CompareTo(triangle2);
            Assert.True(actual);
        }
        [Fact]
        public void TTrianglePrizmCompareTo()
        {
            TTrianglePrizm prizm = new (3, 4, 5, 1);
            TTrianglePrizm prizm2 = new (5, 4, 3, 1);
            var actual = prizm.CompareTo(prizm2);
            Assert.True(actual);
        }
        [Fact]
        public void TTriangleSecondCompareTo()
        {
            TTriangle triangle = new (3, 4, 5);
            TTriangle triangle2 = new (5, 2, 4);
            var actual = triangle.CompareTo(triangle2);
            Assert.False(actual);
        }
        [Fact]
        public void TTrianglePrizmSecondCompareTo()
        {
            TTrianglePrizm prizm = new (3, 4, 5, 1);
            TTrianglePrizm prizm2 = new (3, 4, 5, 2);
            var actual = prizm.CompareTo(prizm2);
            Assert.False(actual);
        }
    }
}
