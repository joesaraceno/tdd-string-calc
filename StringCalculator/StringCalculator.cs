//Create a simple String calculator with the method:
//int add (string numbers)

//The method can take 0, 1,or 2 numbers, and will
//return their sum (for an empty string, it will return 0).

// The mothod can optionally take a custom  Delimiter, which is signified by the string starting with "//<custom delimiter>"  - 
// In this case the values will be in the second part of the string separated by "\n"

//Example valid inputs are: 
//"", "1", "1,2", "//
namespace utility
{
  public class StringCalc
  {
    private readonly IDisplay _display;
    public StringCalc(IDisplay display)
    {
      _display = display;
    }

    private readonly char[] Delimiters = { ',', '\n' };

    private string RenderToDisplay(IEnumerable<int> values, int sum)
    {
      return $"{String.Join(" + ", values)} = {sum}";
    }

    public int Add(string input)
    {
      if (String.IsNullOrEmpty(input))
      {
        return 0;
      }
      if (input.Length == 1)
      {
        return Int32.Parse(input);
      }
      List<int> values;
      if (input.StartsWith("//"))
      {
        var parts = input.Split("\n");
        var customDelimiter = parts.First().Last();
        values = parts.Last().Split(customDelimiter).Select(f => Int32.Parse(f)).ToList();
      }
      else
      {
        values = input.Split(Delimiters).Select(f => Int32.Parse(f)).ToList();
      }

      if (values.Any(f => f < 0))
      {
        throw new ArgumentException($"Found invalid number");
      }
      var sum = values.Sum();

      _display.Show(RenderToDisplay(values, sum));
      return values.Sum();
    }
  }
}
