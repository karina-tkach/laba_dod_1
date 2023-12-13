using laba_dod_1;

namespace PrizmAndTriangleTests
{
    public class ConstuctorsTests
    {
        [Fact]
        public void TTriangleDefaultConstructor()
        {
            TTriangle triangle = new ();
            Assert.True(triangle.A == 1 && triangle.B == 1 && triangle.C == 1);
        }

        [Fact]
        public void TTrianglePrizmDefaultConstructor()
        {
            TTrianglePrizm trianglePrizm = new ();
            Assert.True(trianglePrizm.A == 1 && trianglePrizm.B == 1 && trianglePrizm.C == 1 && trianglePrizm.Height==1);
        }
        [Fact]
        public void TTriangleConstructor()
        {
            TTriangle triangle = new (3,4,5);
            Assert.True(triangle.A == 3 && triangle.B == 4 && triangle.C == 5);
        }

        [Fact]
        public void TTrianglePrizmConstructor()
        {
            TTrianglePrizm trianglePrizm = new (3,4,5,1);
            Assert.True(trianglePrizm.A == 3 && trianglePrizm.B == 4 && trianglePrizm.C == 5 && trianglePrizm.Height == 1);
        }
        [Fact]
        public void TTriangleConstructorException()
        {
            Assert.Throws<Exception>(() => new TTriangle(3, 4, 1));
        }

        [Fact]
        public void TTrianglePrizmConstructorException()
        {
            Assert.Throws<Exception>(() => new TTrianglePrizm(3, 4, 1, 1));
        }
        [Fact]
        public void TTrianglePrizmConstructorExceptionNegativeHeight()
        {
            Assert.Throws<ArgumentException>(() => new TTrianglePrizm(3, 4, 5, -1));
        }
        [Fact]
        public void TTriangleCopyConstructor()
        {
            TTriangle tr = new (3, 4, 5);
            TTriangle triangle = new (tr);
            Assert.True(triangle.A == 3 && triangle.B == 4 && triangle.C == 5);
            Assert.NotSame(tr, triangle);
        }

        [Fact]
        public void TTrianglePrizmCopyConstructor()
        {
            TTrianglePrizm pr = new (3, 4, 5, 1);
            TTrianglePrizm trianglePrizm = new (pr);
            Assert.True(trianglePrizm.A == 3 && trianglePrizm.B == 4 && trianglePrizm.C == 5 && trianglePrizm.Height == 1);
            Assert.NotSame(pr, trianglePrizm);
        }
        [Fact]
        public void TTrianglePrizmCopyConstructorFromTriangle()
        {
            TTriangle tr = new (3, 4, 5);
            TTrianglePrizm trianglePrizm = new (tr,1);
            Assert.True(trianglePrizm.A == 3 && trianglePrizm.B == 4 && trianglePrizm.C == 5 && trianglePrizm.Height == 1);
        }
    }
}