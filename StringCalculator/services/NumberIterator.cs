using utility;

namespace FizzBuzzTests
{
  public class NumberIterator
  {
    private readonly int _count;
    private readonly INumberDisplay _display;
    private readonly IRenderer _renderer;

    public NumberIterator(int count, INumberDisplay display, IRenderer renderer)
    {
      _count = count;
      _display = display;
      _renderer = renderer;
    }

    public void Iterate()
    {
      foreach (var i in Enumerable.Range(0, _count))
      {
        _display.Show(_renderer.GetResult(i + 1));
      }
    }

  }
}