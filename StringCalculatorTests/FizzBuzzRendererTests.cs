using NUnit.Framework;
using utility;

namespace FizzBuzzRendererTests
{
  [TestFixture]
  public class FizzBuzzRendererTests
  {
    private FizzBuzzRenderer _fizzBuzz;

    [SetUp]
    public void SetUp()
    {
      _fizzBuzz = new FizzBuzzRenderer();
    }

    [Test]
    public void should_return_number()
    {
      var input = 1;
      var result = _fizzBuzz.GetResult(input);
      Assert.AreEqual("1", result);
    }

    [Test]
    public void should_return_Fizz_for_3()
    {
      var input = 3;
      var result = _fizzBuzz.GetResult(input);
      Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void should_return_Fizz_for_multiple_of_3()
    {
      var input = 33;
      var result = _fizzBuzz.GetResult(input);
      Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void should_return_Buzz_for_multiple_of_5()
    {
      var input = 25;
      var result = _fizzBuzz.GetResult(input);
      Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void should_return_FizzBuzz_for_multiple_of_5and3()
    {
      var input = 30;
      var result = _fizzBuzz.GetResult(input);
      Assert.AreEqual("FizzBuzz", result);
    }
  }
}