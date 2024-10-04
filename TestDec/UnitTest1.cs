using Lab2;
namespace TestDec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lab2.SystemCount sc = new SystemCount();
            Assert.AreEqual(73, sc.ToDec(111));
            Assert.AreNotEqual(72, sc.ToDec(111));
        }
    }
}