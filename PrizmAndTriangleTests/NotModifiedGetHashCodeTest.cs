using laba_dod_1;


namespace PrizmAndTriangleTests
{
    public class NotModifiedGetHashCodeTest
    {
        [Fact]
        public void TTriangleGetHashCode()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(3, 4, 5);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTriangleSecondGetHashCode()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(4, 5, 3);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTriangleThirdGetHashCode()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(6, 8, 10);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTriangleFourthGetHashCode()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = triangle;
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTrianglePrizmGetHashCode()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(3, 4, 5, 2);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTrianglePrizmSecondGetHashCode()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(5, 4, 3, 3);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTrianglePrizmThirdGetHashCode()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(6, 8, 10, 1);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTrianglePrizmFourthGetHashCode()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = prizm;
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
    }
}
