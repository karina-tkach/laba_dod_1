using laba_dod_1;


namespace PrizmAndTriangleTests
{
    public class NotModifiedEqualsTest
    {
        [Fact]
        public void TTriangleEquals()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(3, 4, 5);
            var actual = triangle.Equals(triangle2);
            Assert.False(actual);
        }
        [Fact]
        public void TTriangleSecondEquals()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(4, 5, 3);
            var actual = triangle.Equals(triangle2);
            Assert.False(actual);
        }
        [Fact]
        public void TTriangleThirdEquals()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = new(6, 8, 10);
            var actual = triangle.Equals(triangle2);
            Assert.False(actual);
        }
        [Fact]
        public void TTriangleFourthEquals()
        {
            TTriangle triangle = new(3, 4, 5);
            TTriangle triangle2 = triangle;
            var actual = triangle.Equals(triangle2);
            Assert.True(actual);
        }
        [Fact]
        public void TTrianglePrizmEquals()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(3, 4, 5, 1);
            var actual = prizm.Equals(prizm2);
            Assert.True(actual);
        }
        [Fact]
        public void TTrianglePrizmSecondEquals()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(3, 4, 5, 2);
            var actual = prizm.Equals(prizm2);
            Assert.True(actual);
        }
        [Fact]
        public void TTrianglePrizmThirdEquals()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = new(6, 8, 10, 1);
            var actual = prizm.Equals(prizm2);
            Assert.False(actual);
        }
        [Fact]
        public void TTrianglePrizmFourthEquals()
        {
            TTrianglePrizm prizm = new(3, 4, 5, 1);
            TTrianglePrizm prizm2 = prizm;
            var actual = prizm.Equals(prizm2);
            Assert.True(actual);
        }
    }
}
