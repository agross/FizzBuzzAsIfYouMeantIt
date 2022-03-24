// See https://aka.ms/new-console-template for more information

using Xunit;

Console.WriteLine("Hello, World!");

public class FizzBuzzTests
{
  [Fact]
  void Should_return_number_for_integer()
  {
    Assert.Equal("1", FizzBuzz(1));
  }

  [Fact]
  public void Should_return_Fizz_for_3()
  {
    Assert.Equal("Fizz", FizzBuzz(3));
  }

  [Fact]
  public void Should_return_Fizz_for_6()
  {
    Assert.Equal("Fizz", FizzBuzz(6));
  }

  [Fact]
  public void Should_return_Buzz_for_5()
  {
    Assert.Equal("Buzz", FizzBuzz(5));
  }

  [Fact]
  public void Should_return_Buzz_for_10()
  {
    Assert.Equal("Buzz", FizzBuzz(10));
  }

  string FizzBuzz(int number)
  {
    var result = number.ToString();

    if (number % 5 == 0)
    {
      result = "Buzz";
    }

    if (number % 3 == 0)
    {
      result = "Fizz";
    }

    return result;
  }
}
