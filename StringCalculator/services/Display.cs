namespace utility
{
  public class Display : IDisplay
  {
    public void Show(IEnumerable<int> values, int sum)
    {
      Console.WriteLine($"{String.Join(" + ", values)} = {sum}");
    }
  }
}