

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("1000")]
    public void SingleNumberReturnsNumber(string number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(number);
        Assert.Equal(int.Parse(number), result);
    }

    [Theory]
    [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9")]
    public void AddTwoNumbersSeparatedByComma(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(45, result);
    }

    [Theory]
    [InlineData("1\n 2\n 3\n 4\n 5\n 6\n 7\n 8\n 9")]
    public void AddTwoNumbersSeparatedByNewLine(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(45, result);
    }

    [Theory]
    [InlineData("1\n 2, 3\n 4\n 5\n 6\n 7\n 8\n 9")]
    public void AddTwoNumbersSeparatedByNewLineAndComma(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(45, result);
    }

    [Theory]
    [InlineData("//#\n1#2#3")]
    public void AddTwoNumbersSeparatedByAllDelimiters(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(6, result);
    }

    [Theory]
    [InlineData("//#\n1#2,3\n1")]
    public void AddTwoNumbersSeparatedByAllDelimitersAndPreviousOnes(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(7, result);
    }
}
    