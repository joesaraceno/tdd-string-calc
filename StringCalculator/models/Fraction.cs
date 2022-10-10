namespace fractions
{
  public class Fraction
  {
    private readonly int _gcd;
    private readonly int _numerator;
    private readonly int _denominator;

    public override string ToString() =>
      _denominator != 1 ?
        $"{_numerator}/{_denominator}" :
        $"{_numerator}";
    public Fraction(int numerator, int denominator = 1)
    {
      _gcd = GlobalCommonDenominator(numerator, denominator);
      _numerator = numerator / _gcd;
      _denominator = denominator / _gcd;
    }

    public Fraction Add(Fraction other)
    {
      // just add the numerators
      var num = _numerator + other._numerator;
      if (_denominator != other._denominator)
      {
        // if they aren't same denominator
        // crossmultiply to get the right numerator
        num = other._denominator * _numerator;
        num += _denominator * other._numerator;
      }
      var den = _denominator;
      if (_denominator != other._denominator)
      {
        // if they aren't the same denominator
        // multiply them straight
        den = _denominator * other._denominator;
      }
      return new Fraction((num), den);
    }

    private int GlobalCommonDenominator(int num, int den)
    {
      while (num != den)
      {
        if (num > den)
        {
          num = num - den;
        }
        else
        {
          den = den - num;
        }
      }
      return num;
    }
  }
}