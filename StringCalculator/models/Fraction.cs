namespace fractions
{
  public class Fraction
  {
    private readonly int _gcd;
    private readonly int _numerator;
    private readonly int _denominator;

    public override string ToString()
    {
      var result = "";
      var num = _numerator;
      var whole_numbers = 0;

      while (num > _denominator)
      {
        num -= _denominator;
        whole_numbers++;
      }

      if (whole_numbers > 0)
      {
        result = $"{whole_numbers} ";
      }

      result += num;

      if (_denominator != 1)
      {
        result = $"{result}/{_denominator}";
      }
      else
      {
        result = $"{_numerator}";
      }
      return result;

    }

    private string Simplify()
    {
      var remainder = _numerator % _denominator;
      var whole = (_numerator / _denominator) + remainder;
      return remainder.ToString();
      // return new Fraction(_numerator, _denominator).ToString();
    }

    public Fraction(int numerator, int denominator = 1)
    {
      _gcd = GlobalCommonDenominator(numerator, denominator);
      _numerator = numerator / _gcd;
      _denominator = denominator / _gcd;
    }

    public Fraction Add(Fraction other)
    {
      return new Fraction((AddNumerators(other)),
        AddDenominators(other));
    }

    // if they aren't the same denominator
    // multiply them straight
    private int AddDenominators(Fraction other)
    {
      return _denominator != other._denominator ?
        _denominator * other._denominator :
        _denominator;
    }
    private int AddNumerators(Fraction other)
    {
      var num = _numerator + other._numerator;
      if (_denominator != other._denominator)
      {
        // if they aren't same denominator
        // crossmultiply to get the right numerator
        num = other._denominator * _numerator;
        num += _denominator * other._numerator;
      }
      return num;
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