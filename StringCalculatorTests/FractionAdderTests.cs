using NUnit.Framework;

namespace fractions.Tests
{

  [TestFixture]
  public class FractionTests
  {
    [Test]
    public void ShouldAddSimpleIntegerFractions()
    {
      Assert.AreEqual("3", new Fraction(1).Add(new Fraction(2)).ToString());
    }

    [Test]
    public void ShouldAddNonReductiveFractions()
    {
      Assert.AreEqual("3/5", new Fraction(1, 5).Add(new Fraction(2, 5)).ToString());
    }

    [Test]
    public void ShouldAddAndReduceSimpleFractions()
    {
      Assert.AreEqual("1/2", new Fraction(1, 4).Add(new Fraction(1, 4)).ToString());
    }

    [Test]
    public void ShouldAddAndReduceMixedDenominatorsFractions()
    {
      Assert.AreEqual("7/12", new Fraction(1, 4).Add(new Fraction(1, 3)).ToString());
    }
  }
}