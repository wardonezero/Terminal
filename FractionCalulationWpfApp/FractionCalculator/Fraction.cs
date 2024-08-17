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
    public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a._numerator * b._denominator + a._denominator * b._numerator, a._denominator * b._denominator);
    public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
    public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a._numerator * b._numerator, a._denominator * b._denominator);
    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b._numerator == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        return new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);
    }
    public override string ToString() => $"{_numerator} / {_denominator}";
}