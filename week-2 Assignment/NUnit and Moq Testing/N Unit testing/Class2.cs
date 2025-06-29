using NUnit.Framework;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator.AllClear();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 5, 5)]
        public void Addition_ValidInputs_ReturnsExpectedResult(double a, double b, double expected)
        {
            double result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Not implemented")]
        public void Division_TestPlaceholder()
        {
        }
    }
}
