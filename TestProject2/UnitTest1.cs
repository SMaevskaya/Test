using MyLib;
namespace TestProject2

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circle sh = new Circle(2);           
            double expected = Math.PI*4;
            double result = sh.Square();                        
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Triangle sh = new Triangle(6,8,10);
            double expected = 24;
            double result = sh.Square();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Triangle sh1 = new Triangle(5, 8, 10);
            bool expected = false;
            bool result = sh1.IsRightTtiangle();
            Assert.AreEqual(expected, result);
        }
    }
}