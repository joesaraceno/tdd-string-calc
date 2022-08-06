using NUnit.Framework;
using Moq;
using System;
using utility;

namespace FizzBuzzTests
{
  [TestFixture]
  public class FizzBuzzTests
  {
    private FizzBuzz _fizzBuzz;

    [SetUp]
    public void SetUp()
    {
      _fizzBuzz = new FizzBuzz();
    }

    [Test]
    public void test_should_reject_negative_numbers()
    {
      var input = -1;
      Assert.Throws<ArgumentException>(() => _fizzBuzz.GetResult(input));
    }

    [Test]
    public void test_should_reject_numbers_above_100()
    {
      var input = 101;
      Assert.Throws<ArgumentException>(() => _fizzBuzz.GetResult(input));
    }
  }
}