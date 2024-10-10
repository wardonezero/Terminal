namespace FractionCalculator;
public struct Fraction
{
    private readonly int _numerator;
    private readonly int _denominator;
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
        _numerator = numerator;
        _denominator = denominator;
    }
    public static Fraction operator +(Fraction a) => a;
    public static Fraction operator -(Fraction a) => new(-a._numerator, a._denominator);
    public static Fraction operator +(Fraction a, Fraction b)
    {
        if (a._denominator == b._denominator)
            return Simplifier(new Fraction(a._numerator + b._numerator, a._denominator));
        else
        {
            int lcm = LCM(a._denominator, b._denominator);
            return Simplifier(new Fraction((lcm / a._denominator) * a._numerator + (lcm / b._denominator) * b._numerator, lcm));
        }
        //return new Fraction(a._numerator * b._denominator + a._denominator * b._numerator, a._denominator * b._denominator);
    }
    public static Fraction operator -(Fraction a, Fraction b)
    {
        if (a._denominator == b._denominator)
            return new Fraction(a._numerator - b._numerator, a._denominator);
        else
        {
            int lcm = LCM(a._denominator, b._denominator);
            return Simplifier(new Fraction((lcm / a._denominator) * a._numerator - (lcm / b._denominator) * b._numerator, lcm));
        }
        //return new Fraction(a._numerator * b._denominator - a._denominator * b._numerator, a._denominator * b._denominator);
    }
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return Simplifier(new Fraction(a._numerator * b._numerator, a._denominator * b._denominator));
    }
    public static Fraction operator /(Fraction a, Fraction b)
    {
        return Simplifier(new Fraction(a._numerator * b._denominator, a._denominator * b._numerator));
    }
    public override string ToString() => $"{_numerator} / {_denominator}";
    private static Fraction Simplifier(Fraction s)
    {
        int gcd = s._numerator < s._denominator ? GCD(s._denominator, s._numerator) : GCD(s._numerator, s._denominator);
        return new Fraction(s._numerator / gcd, s._denominator / gcd);
    }
    //Greatest Common Divisor
    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of two integers using the Euclidean algorithm.
    /// </summary>
    /// <param name="quotient">The first integer</param>
    /// <param name="remainder"> The second integer.</param>
    /// <returns>The GCD of the two integers.</returns>
    /// <remarks>
    /// The method repeatedly replaces the quotient and remainder with the remainder and the quotient modulo remainder, respectively, until the remainder is zero.
    /// The last non-zero remainder is the GCD.
    /// </remarks>
    private static int GCD(int quotient, int remainder)
    {
        int temp;
        while (true)
        {
            if (remainder == 0)
            {
                return quotient;
            }
            else
            {
                temp = remainder;
                remainder = quotient % remainder;
                quotient = temp;
            }
        }
    }
    //Least Common Denominator
    /// <summary>
    /// Calculates the Least Common Multiple (LCM) of two integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The LCM of the two integers.</returns>
    /// <remarks>
    /// The method first calculates the Greatest Common Divisor (GCD) of the two integers using a helper method `GCD`.
    /// It then computes the LCM using the formula: (a / gcd) * b.
    /// </remarks>
    private static int LCM(int a, int b)
    {
        int gcd = a < b ? GCD(a, b) : GCD(b, a);
        int lcm = (a / gcd) * b;
        return lcm;
    }
}