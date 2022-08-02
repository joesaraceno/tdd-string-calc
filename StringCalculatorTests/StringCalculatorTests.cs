using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using utility;

namespace Prime.UnitTests.Services
{
  [TestFixture]
  public class PrimeService_IsPrimeShould
  {
    private StringCalc _stringCalc;
    private Mock<IDisplay> _displayMock = new Mock<IDisplay>();

    [SetUp]
    public void SetUp()
    {
      _stringCalc = new StringCalc();
    }

    [Test]
    public void test_should_return_zero_for_empty_string()
    {
      var stringCalculator = new StringCalc();
      Assert.AreEqual(0, stringCalculator.Add(""));
    }

    [Test]
    public void test_should_return_value_of_single_number()
    {
      var stringCalculator = new StringCalc();
      Assert.AreEqual(1, stringCalculator.Add("1"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers()
    {
      var stringCalculator = new StringCalc();
      Assert.AreEqual(3, stringCalculator.Add("1,2"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers_with_multiple_delimiters()
    {
      var stringCalculator = new StringCalc();
      Assert.AreEqual(6, stringCalculator.Add("1\n2,3"));
    }

    [Test]
    public void test_should_return_sum_of_multiple_numbers_with_user_defined_delimiters()
    {
      var stringCalculator = new StringCalc();
      Assert.AreEqual(9, stringCalculator.Add("//]\n3]6"));
    }

    [Test]
    public void test_should_throw_exception_with_negative_number()
    {
      var stringCalculator = new StringCalc();
      Assert.Throws<ArgumentException>(() => stringCalculator.Add("-1,2"));
    }

    [Test]
    public void test_should_throw_exception_with_negative_number_with_explanation()
    {
      var stringCalculator = new StringCalc();
      var e = Assert.Throws<ArgumentException>(() => stringCalculator.Add("-1,2"));
      Assert.AreEqual("Found invalid number", e?.Message);
    }

    [Test]
    public void test_should_call_display_with_correct_arguments()
    {
      var stringCalculator = new StringCalc(_displayMock.Object);
      var list = new List<int>() { 1, 2 };
      stringCalculator.Add("1,2");
      _displayMock.Verify(f => f.Show(list, 3));
    }
  }

}