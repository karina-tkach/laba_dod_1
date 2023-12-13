namespace laba_dod_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            TTriangle first = new TTriangle(3, 4, 5);
            HashSet<TTriangle> triangles = new HashSet<TTriangle>() { first };
            TTriangle second = new TTriangle(3, 4, 5);
            Console.WriteLine(triangles.Contains(second));

            TTriangleF firstF = new TTriangleF(3, 4, 5);
            HashSet<TTriangleF> trianglesF = new HashSet<TTriangleF>() { firstF };
            TTriangleF secondF = new TTriangleF(3, 4, 5);
            Console.WriteLine(trianglesF.Contains(secondF));


            TTrianglePrizm firstP = new TTrianglePrizm(3, 4, 5, 1);
            TTrianglePrizm secondP = new TTrianglePrizm(3, 4, 5, 2);
            TTrianglePrizm thirdP = new TTrianglePrizm(3, 4, 5, 3);
            TTrianglePrizm fourthP = new TTrianglePrizm(3, 4, 5, 4);
            TTrianglePrizm fifthP = new TTrianglePrizm(3, 4, 5, 5);
            HashSet<TTrianglePrizm> prizms = new HashSet<TTrianglePrizm>() { firstP, secondP, thirdP, fourthP, fifthP };
            Console.WriteLine(prizms.Count);

            TTrianglePrizmF firstPF = new TTrianglePrizmF(3, 4, 5, 1);
            TTrianglePrizmF secondPF = new TTrianglePrizmF(3, 4, 5, 2);
            TTrianglePrizmF thirdPF = new TTrianglePrizmF(3, 4, 5, 3);
            TTrianglePrizmF fourthPF = new TTrianglePrizmF(3, 4, 5, 4);
            TTrianglePrizmF fifthPF = new TTrianglePrizmF(3, 4, 5, 5);
            HashSet<TTrianglePrizmF> prizmsF = new HashSet<TTrianglePrizmF>() { firstPF, secondPF, thirdPF, fourthPF, fifthPF };
            Console.WriteLine(prizmsF.Count);
        }
    }
}