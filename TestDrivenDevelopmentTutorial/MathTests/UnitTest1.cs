using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentTutorial;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();

            double ExpectedResult = 2.0;
            double Input = ExpectedResult * ExpectedResult;

            double ActualResult = rooter.SquareRoot(Input);

            Assert.AreEqual(ExpectedResult, ActualResult, delta: ExpectedResult / 100);
        }

        [TestMethod]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();

            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
            {
                RooterOneValue(rooter, expected);
            }

        }

        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);

            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();

            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

            Assert.Fail();
        }

    }
}
