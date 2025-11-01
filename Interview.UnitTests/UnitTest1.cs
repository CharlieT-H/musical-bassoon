namespace Interview.UnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "BuzzFizz")]
    [InlineData(33, "FizzJazz")]
    [InlineData(7, "Bazz")]
    [InlineData(11, "Jazz")]

    public void FizzBuzz_ReturnsExpectedResult(int input, string expected)
    {
        var fizzBuzz = new Interview.ConsoleRunner.FizzBuzz();
        Assert.Equal(expected, fizzBuzz.Run(input));
    }
}