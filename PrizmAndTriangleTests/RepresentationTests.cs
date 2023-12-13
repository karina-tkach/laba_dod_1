using laba_dod_1;

namespace PrizmAndTriangleTests
{
    public class RepresentationTests
    {
        [Fact]
        public void TTriangleToString()
        {
            string actual = new TTriangle(3, 4, 5).ToString();
            string expected = $"Triangle with sides: a=3, b=4, c=5";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TTrianglePrizmToString()
        {
            string actual = new TTrianglePrizm(3, 4, 5,2).ToString();
            string expected = $"Triangular prizm with base sides: a=3, b=4, c=5 and height h=2";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TTrianglePrintInfo()
        {
            string expected = $"Side a: 3\nSide b: 4\nSide c: 5\nTriangle's perimeter: 12\nTriangle's area: 6\r\n";
            TTriangle triangle = new (3, 4, 5);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            triangle.PrintInfo();
            var output = stringWriter.ToString();
            Assert.Equal(expected, output);
            
        }
        [Fact]
        public void TTrianglePrizmPrintOutput()
        {
            string expected = $"Sides of triangle base:\na=3\nb=4\nc=5\nHeight: h=1\nPerimeter of base: 12\nSurface area : 24\nVolume:6\r\n";
            TTrianglePrizm prizm = new (3, 4, 5,1);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            prizm.PrintInfo();
            var output = stringWriter.ToString();
            Assert.Equal(expected, output);
        }
    }
}
