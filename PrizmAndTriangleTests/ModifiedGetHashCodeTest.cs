using laba_dod_1;


namespace PrizmAndTriangleTests
{
    public class ModifiedGetHashCodeTest
    {
        [Fact]
        public void TTriangleFGetHashCode()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(3, 4, 5);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first==second);
        }
        [Fact]
        public void TTriangleFSecondGetHashCode()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(4, 5, 3);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTriangleFThirdGetHashCode()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(6, 8, 10);
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTriangleFFourthGetHashCode()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = triangle;
            var first = triangle.GetHashCode();
            var second = triangle2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTriangleFPrizmGetHashCode()
        {
            TTrianglePrizmF prizm = new(3, 4, 5,1);
            TTrianglePrizmF prizm2 = new(3, 4, 5,1);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTrianglePrizmFSecondGetHashCode()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = new(5, 4, 3, 1);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
        [Fact]
        public void TTrianglePrizmFThirdGetHashCode()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = new(6, 8, 10, 1);
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first != second);
        }
        [Fact]
        public void TTrianglePrizmFFourthGetHashCode()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = prizm;
            var first = prizm.GetHashCode();
            var second = prizm2.GetHashCode();
            Assert.True(first == second);
        }
    }
}
