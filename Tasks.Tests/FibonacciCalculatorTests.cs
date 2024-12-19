namespace Tasks.Tests
{
    [TestFixture]
    public class FibonacciCalculatorTests
    {
        [Test]
        public void Test_Fibonacci_BaseCases()
        {
            Assert.That(FibonacciCalculator.Calculate(0), Is.EqualTo(0));
            Assert.That(FibonacciCalculator.Calculate(1), Is.EqualTo(1));
        }

        [Test]
        public void Test_Fibonacci_ValidCase()
        {
            Assert.That(FibonacciCalculator.Calculate(8), Is.EqualTo(21));
        }
    }
}