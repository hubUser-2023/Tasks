namespace Tasks
{
    public class QuadraticSolver
    {
        public static double[] Solve(double coefficientA, double coefficientB, double coefficientC)
        {
            if (coefficientA == 0) throw new ArgumentException("Коэффициент 'a' должен быть не равен нулю.");

            double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;
            if (discriminant < 0) return Array.Empty<double>();

            double root1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
            if (discriminant == 0) return new[] { root1 };

            double root2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            return new[] { root1, root2 };
        }
    }
}