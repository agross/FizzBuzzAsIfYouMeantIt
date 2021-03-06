// See https://aka.ms/new-console-template for more information

using Xunit;
using Xunit.Abstractions;

Numbers.Print(100, Console.WriteLine, FizzBuzz.Translate);

public class FizzBuzzTests
{
  [Fact]
  void Should_return_number_for_integer()
  {
    Assert.Equal("1", FizzBuzz.Translate(1));
  }

  [Fact]
  public void Should_return_Fizz_for_3()
  {
    Assert.Equal("Fizz", FizzBuzz.Translate(3));
  }

  [Fact]
  public void Should_return_Fizz_for_6()
  {
    Assert.Equal("Fizz", FizzBuzz.Translate(6));
  }

  [Fact]
  public void Should_return_Buzz_for_5()
  {
    Assert.Equal("Buzz", FizzBuzz.Translate(5));
  }

  [Fact]
  public void Should_return_Buzz_for_10()
  {
    Assert.Equal("Buzz", FizzBuzz.Translate(10));
  }

  [Fact]
  public void Should_return_FizzBuzz_for_15()
  {
    Assert.Equal("FizzBuzz", FizzBuzz.Translate(15));
  }
}

public class NumbersTests
{
  int CountOfDisplayedNumbers;
  readonly ICollection<string> RenderedNumbers = new List<string>();

  [Fact]
  public void Should_display_each_number()
  {
    Numbers.Print(2, Display, Renderer);

    Assert.Equal(2, CountOfDisplayedNumbers);
  }

  [Fact]
  public void Should_render_each_number()
  {
    Numbers.Print(1, Display, Renderer);

    Assert.Equal("rendered 1", RenderedNumbers.First());
  }

  void Display(string renderedNumber)
  {
    CountOfDisplayedNumbers = CountOfDisplayedNumbers + 1;
    RenderedNumbers.Add(renderedNumber);
  }

  string Renderer(int number) => "rendered " + number;
}

public class FizzBuzzKataTests
{
  readonly ITestOutputHelper _output;

  public FizzBuzzKataTests(ITestOutputHelper output)
  {
    _output = output;
  }

  [Fact]
  public void Should_work()
  {
    Numbers.Print(100, _output.WriteLine, FizzBuzz.Translate);
  }
}

public static class FizzBuzz
{
  internal static string Translate(int number)
  {
    var result = "";

    if (number % 3 == 0)
    {
      result += "Fizz";
    }

    if (number % 5 == 0)
    {
      result += "Buzz";
    }

    if (result == "")
    {
      result = number.ToString();
    }

    return result;
  }
}

public class Numbers
{
  public static void Print(int count, Action<string> display, Func<int, string> renderer)
  {
    Enumerable.Range(1, count)
              .ToList()
              .ForEach(i => display(renderer(i)));
  }
}
