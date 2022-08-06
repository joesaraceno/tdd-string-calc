namespace utility
{
  /*
  Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz" 
  12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19Buzz... etc up to 100Continuous Delivery LtdRegistered Company No: 9094073 England& WalesVAT: GB 190 6295 90
 */
  public class FizzBuzz
  {

    public FizzBuzz()
    {

    }
    public string GetResult(int input)
    {
      if (input <= 0 || input > 100)
      {
        throw new ArgumentException();
      }
      return "";
    }
  }

}
