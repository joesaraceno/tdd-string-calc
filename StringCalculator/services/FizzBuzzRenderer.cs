
namespace utility
{
  /*
  Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz" 
  12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19Buzz... etc up to 100Continuous Delivery LtdRegistered Company No: 9094073 England& WalesVAT: GB 190 6295 90
 */
  public class FizzBuzzRenderer : IRenderer
  {

    public FizzBuzzRenderer()
    {

    }
    public string GetResult(int input)
    {
      string output = "";
      if (input % 3 == 0)
      {
        output += "Fizz";
      }
      if (input % 5 == 0)
      {
        output += "Buzz";
      }
      if (String.IsNullOrEmpty(output))
      {
        output = input.ToString();
      }
      return output;
    }
  }

}
