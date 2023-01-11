using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProyect.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2,2) == 4);
            Assert.IsFalse(calculator.Add(2, 3) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 4) == 8);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(12, 4) == 3);

        }
    }
}

namespace CalculatorProyectTests
{
    internal class CalculatorTests
    {
    }
}
