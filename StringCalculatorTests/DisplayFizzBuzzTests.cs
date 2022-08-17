using NUnit.Framework;
using utility;

[TestFixture]
public class DisplayFizzBuzzTests
{
  [Test]
  public void TestDisplaysFizzBuzz()
  {
    var renderer = new FizzBuzzRenderer();
    var display = new ConsoleDisplay();
    var iterator = new NumberIterator(50, display, renderer);
    iterator.Iterate();
  }
}