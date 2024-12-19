namespace Tasks.Tests
{
    [TestFixture]
    public class QuadraticSolverTests
    {
        public void Test_SingleRoot()
        {
            double[] result = QuadraticSolver.Solve(1, -2, 1);
            Assert.That(result, Is.EqualTo(new[] { 1.0 }));
        }

        [Test]
        public void Test_TwoRoots()
        {
            double[] result = QuadraticSolver.Solve(1, -3, 2);
            Assert.That(result, Is.EqualTo(new[] { 2.0, 1.0 }));
        }

        [Test]
        public void Test_NoRealRoots()
        {
            double[] result = QuadraticSolver.Solve(1, 0, 1);
            Assert.That(result, Is.Empty);
        }
    }
}