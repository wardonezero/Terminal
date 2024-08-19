﻿namespace FractionCalculator;
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
        int[] lcd = [a._denominator, b._denominator];
        if (a._denominator == b._denominator)
            return new Fraction(a._numerator + b._numerator, a._denominator);
        else
            return new Fraction(a._numerator * b._denominator + a._denominator * b._numerator, a._denominator * b._denominator);
    }
    public static Fraction operator -(Fraction a, Fraction b)
    {
        if (a._denominator == b._denominator)
            return new Fraction(a._numerator - b._numerator, a._denominator);
        else
            return new Fraction(a._numerator * b._denominator - a._denominator * b._numerator, a._denominator * b._denominator);
    }
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a._numerator * b._numerator, a._denominator * b._denominator);
    }
    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);
    }
    public override string ToString() => $"{_numerator} / {_denominator}";
}