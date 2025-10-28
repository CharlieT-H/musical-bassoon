namespace Interview.UnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(7, "7")]

    public void FizzBuzz_ReturnsExpectedResult(int input, string expected)
    {
        var fizzBuzz = new Interview.ConsoleRunner.FizzBuzz();
        Assert.Equal(expected, fizzBuzz.Run(input));
    }
}