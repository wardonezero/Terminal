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
    public static Fraction operator -(Fraction a) => new Fraction(-a._numerator, a._denominator);
    public static Fraction operator +(Fraction a, Fraction b)
    {
        if (a._denominator == b._denominator)
            return Simplifier(new Fraction(a._numerator + b._numerator, a._denominator));
        else
        {
            int lcm = LCM(a._denominator, b._denominator);
            return Simplifier(new Fraction((lcm/a._denominator)*a._numerator+ (lcm / b._denominator) * b._numerator, lcm));
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
        int gcd = s._numerator < s._denominator? GCD(s._denominator, s._numerator): GCD(s._numerator, s._denominator);
        return new Fraction(s._numerator / gcd, s._denominator / gcd);
    }
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
    private static int LCM(int a, int b)
    {
        int gcd = a < b ? GCD(a, b) : GCD(b, a);
        int lcm = (a / gcd) * b;
        return lcm;
    }
}