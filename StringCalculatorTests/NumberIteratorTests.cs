using Moq;
using NUnit.Framework;
using utility;

namespace FizzBuzzTests
{
  [TestFixture]
  public class NumberIteratorTests
  {
    private int _count;
    private NumberIterator _iterator;
    private Mock<IDisplay> _display;
    private Mock<IRenderer> _renderer;

    [SetUp]
    public void SetUp()
    {
      _count = 0;
      _display = new Mock<IDisplay>();
      _renderer = new Mock<IRenderer>();
    }

    [Test]
    public void Should_Iterate_Given_Times()
    {
      _display.Setup(f => f.Show(It.IsAny<string>())).Callback(() => _count++);
      _iterator = new NumberIterator(2, _display.Object, _renderer.Object);
      _iterator.Iterate();
      Assert.AreEqual(2, _count);
    }

    [Test]
    public void Should_Render_Each_Number()
    {
      _renderer.Setup(f => f.GetResult(It.IsAny<int>())).Returns("XX");
      _iterator = new NumberIterator(1, _display.Object, _renderer.Object);
      _iterator.Iterate();
      _display.Verify(f => f.Show("XX"));
    }
  }

}