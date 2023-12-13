using laba_dod_1;


namespace PrizmAndTriangleTests
{
    public class ModifiedEqualsTest
    {
        [Fact]
        public void TTriangleFEquals()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(3, 4, 5);
            var actual = triangle.Equals(triangle2);
            Assert.True(actual);
        }
        [Fact]
        public void TTriangleFSecondEquals()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(4, 5, 3);
            var actual = triangle.Equals(triangle2);
            Assert.True(actual);
        }
        [Fact]
        public void TTriangleFThirdEquals()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = new(6, 8, 10);
            var actual = triangle.Equals(triangle2);
            Assert.False(actual);
        }
        [Fact]
        public void TTriangleFFourthEquals()
        {
            TTriangleF triangle = new(3, 4, 5);
            TTriangleF triangle2 = triangle;
            var actual = triangle.Equals(triangle2);
            Assert.True(actual);
        }
        [Fact]
        public void TTriangleFPrizmEquals()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = new(3, 5, 4, 1);
            var actual = prizm.Equals(prizm2);
            Assert.True(actual);
        }
        [Fact]
        public void TTrianglePrizmFSecondEquals()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = new(3, 5, 4, 2);
            var actual = prizm.Equals(prizm2);
            Assert.False(actual);
        }
        [Fact]
        public void TTrianglePrizmFThirdEquals()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = new(6, 8, 10, 1);
            var actual = prizm.Equals(prizm2);
            Assert.False(actual);
        }
        [Fact]
        public void TTrianglePrizmFFourthEquals()
        {
            TTrianglePrizmF prizm = new(3, 4, 5, 1);
            TTrianglePrizmF prizm2 = prizm;
            var actual = prizm.Equals(prizm2);
            Assert.True(actual);
        }
    }
}
