namespace utility
{
  public class NumberIterator
  {
    private readonly int _count;
    private readonly IDisplay _display;
    private readonly IRenderer _renderer;

    public NumberIterator(int count, IDisplay display, IRenderer renderer)
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