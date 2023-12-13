using laba_dod_1;

namespace PrizmAndTriangleTests
{
    public class CharacterisicsTests
    {
        [Fact]
        public void TTrianglePerimeter()
        {
            TTriangle triangle = new (3,4,5);
            Assert.True(triangle.Perimeter()==12.0);
        }
        [Fact]
        public void TTriangleArea()
        {
            TTriangle triangle = new (3, 4, 5);
            Assert.True(triangle.Area() == 6.0);
        }
        [Fact]
        public void TTriangleSecondArea()
        {
            TTriangle triangle = new (5, 10, 14);
            Assert.True(Math.Round(triangle.Area(),2)==17.61);
        }
        [Fact]
        public void TTrianglePrizmVolume()
        {
            TTrianglePrizm prizm = new (3,4,5,10);
            Assert.True(prizm.Volume()==60.0);
        }
        [Fact]
        public void TTrianglePrizmSecondVolume()
        {
            TTrianglePrizm prizm = new (5, 10, 14, 10);
            Assert.True(Math.Round(prizm.Volume(), 1) == 176.1);
        }
        [Fact]
        public void TTrianglePrizmArea()
        {
            TTrianglePrizm prizm = new (4, 4, 4, 2);
            Assert.True(Math.Round(prizm.Area(), 2) == 37.86);
        }
        [Fact]
        public void TTrianglePrizmSecondArea()
        {
            TTrianglePrizm prizm = new (6, 8, 10, 10);
            Assert.True(prizm.Area() == 288.0);
        }
    }
}
