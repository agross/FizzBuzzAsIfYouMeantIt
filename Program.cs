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

  string FizzBuzz(int number)
  {
    return number.ToString();
  }
}
