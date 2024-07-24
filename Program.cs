
using System.ComponentModel;

namespace AppWeek3Part3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // make new instance and print it 
            Rational rational1 = new Rational(5);
            WriteRational(rational1);

            Rational rational2 = new Rational(20, 5);
            Rational rational3 = new Rational(30, 5);
            Rational rational4 = new Rational(50, 40);

            // testing negate method
            rational1.Negate();
            Console.WriteLine("Testing negate");
            WriteRational(rational1);

            // testing invert method
            rational1.Invert();
            Console.WriteLine("Testing invert");
            WriteRational(rational1);

            // testing toDouble
            Console.WriteLine("Testing toDouble");
            Console.WriteLine(rational1.ToDouble());

            // testing reduce
            Console.WriteLine("Testing reduce staring as 20 / 5");
            WriteRational(rational2.Reduce());

            // testing add
            Console.WriteLine("Testing Add");
            Rational sum = Rational.Add(rational3, rational4);
            WriteRational(sum);
        }
        public static void WriteRational(Rational rational)
        {
            Console.Write(rational.numerator);
            Console.Write("/");
            Console.WriteLine(rational.denominator);
        }

    }
}
