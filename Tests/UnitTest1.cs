using ConsoleApp1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsvalueFine()
        {
            var triangle1 = new Triangle(new double[] { 3, 4, 5 });
            var circle = new Circle(10);
            Assert.AreEqual(6, triangle1.Area);
            Assert.AreEqual(314.1592653589793, circle.Area);
          

        }

        [Test]
        public void ThrowExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { -1, 2, 2 }));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}