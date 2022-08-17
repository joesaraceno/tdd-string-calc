namespace utility
{
  public class ConsoleDisplay : IDisplay
  {
    public void Show(string toShow)
    {
      Console.WriteLine(toShow);
    }
  }
}