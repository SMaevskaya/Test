using System.ComponentModel;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shape sh = new Shape(2, 3, 6);
            double a = 2;
            double d = 3;
            double c = 6; 
            double expected = 6;
            // act
            double result = sh.Square();
            // assert            
            Assert.AreEqual(expected, result);
        }
    }
}