using Moq;
using NUnit.Framework;
using System;

using utility;

namespace StringCalculator.UnitTests.Services
{
  [TestFixture]
  public class PrimeService_IsPrimeShould
  {
    private StringCalc _stringCalc;
    private Mock<IDisplay> _displayMock = new Mock<IDisplay>();

    [SetUp]
    public void SetUp()
    {
      _stringCalc = new StringCalc(_displayMock.Object);
    }

    [Test]
    public void test_should_return_zero_for_empty_string()
    {
      Assert.AreEqual(0, _stringCalc.Add(""));
    }

    [Test]
    public void test_should_return_value_of_single_number()
    {
      Assert.AreEqual(1, _stringCalc.Add("1"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers()
    {
      Assert.AreEqual(3, _stringCalc.Add("1,2"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers_with_multiple_delimiters()
    {
      Assert.AreEqual(6, _stringCalc.Add("1\n2,3"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers_with_user_defined_delimiters()
    {
      Assert.AreEqual(9, _stringCalc.Add("//]\n3]6"));
    }

    [Test]
    public void test_should_throw_exception_with_negative_number()
    {
      Assert.Throws<ArgumentException>(() => _stringCalc.Add("-1,2"));
    }

    [Test]
    public void test_should_throw_exception_with_negative_number_with_explanation()
    {
      var e = Assert.Throws<ArgumentException>(() => _stringCalc.Add("-1,2"));
      Assert.AreEqual("Found invalid number", e?.Message);
    }

    [Test]
    public void test_should_call_display_correctly()
    {
      _stringCalc.Add("1,2");
      _displayMock.Verify(f => f.Show("1 + 2 = 3"));
    }
  }
}