
namespace AppWeek3Part3
{
    public class Rational
    {
        public int numerator;

        public int denominator;

        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Rational(int numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }
        public void Negate()
        {
            numerator = -numerator;
        }
        public void Invert()
        {
            if (numerator == 0)
            {
                throw new InvalidOperationException("Cannot invert a rational number with a numerator of zero.");
            }

            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }
        public Rational Reduce()
        {
            int gcd = GCD(numerator, denominator);
            int reducedNumerator = numerator / gcd;
            int reducedDenominator = denominator / gcd;

            // Ensure the denominator is positive
            if (reducedDenominator < 0)
            {
                reducedNumerator = -reducedNumerator;
                reducedDenominator = -reducedDenominator;
            }

            return new Rational(reducedNumerator, reducedDenominator);
        }
        private int GCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
        public static Rational Add(Rational r1, Rational r2)
        {
            int commonDenominator = r1.denominator * r2.denominator;
            int numeratorSum = (r1.numerator * r2.denominator) + (r2.numerator * r1.denominator);

            Rational result = new Rational(numeratorSum, commonDenominator);
            return result.Reduce();
        }
    }
}
