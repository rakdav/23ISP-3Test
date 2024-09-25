using UnitTest;

namespace TestUnitTest
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void TestMethodSum()
        {
            Assert.AreEqual(MyMath.Sum(4,7),11);
            Assert.AreEqual(MyMath.Sum(-4, 7), 3);
            Assert.AreEqual(MyMath.Sum(0, 7), 7);
            Assert.AreEqual(MyMath.Sum(-1, -9), -10);
            Assert.AreEqual(MyMath.Sum(11, 4), 15);
        }
        [TestMethod]
        public void TestMethodFact()
        {
            Assert.AreEqual(MyMath.Fact(4), 24);
            Assert.AreEqual(MyMath.Fact(5), 120);
            Assert.AreEqual(MyMath.Fact(6), 720);
            Assert.AreEqual(MyMath.Fact(-2), 1);
        }
    }
}