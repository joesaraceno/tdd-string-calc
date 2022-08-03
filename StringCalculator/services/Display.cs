namespace utility
{
  public class Display : IDisplay
  {
    public void Show(string toShow)
    {
      Console.WriteLine(toShow);
    }
  }
}