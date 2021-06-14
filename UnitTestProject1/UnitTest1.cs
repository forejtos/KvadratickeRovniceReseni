using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratickeRovniceReseni;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2.0,2.0,-4.0, 1.0)]
        [DataRow(2.0, -11.0, 14.0, 3.5)]
        public void TestMethod1(double a, double b, double c, double vysledek)
        {
            //Arrange
            //Act

            double x1 = Program.x1(a, b, c);

            //Assert
            Assert.IsTrue((x1 - vysledek) < 1e-7);
        }
    }
}
