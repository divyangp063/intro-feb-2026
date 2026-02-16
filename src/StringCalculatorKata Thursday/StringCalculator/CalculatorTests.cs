

namespace StringCalculator;
public class CalculatorTests
{
    private Calculator _calculator;
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("1000", 1000)]
    public void SingleNumberReturnsNumber(string number, int expected)
    {

        var result = _calculator.Add(number);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2, 3", 6)]
    [InlineData("1, 2, 3, 4, 5", 15)]
    [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9", 45)]
    public void AddTwoNumbersSeparatedByComma(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("7\n8\n20", 35)]
    [InlineData("1\n 2\n 3\n 4\n 5\n 6\n 7\n 8\n 9", 45)]
    public void AddTwoNumbersSeparatedByNewLine(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n 2, 3\n", 6)]
    [InlineData("1\n 2, 3\n 4\n 5\n 6\n 7\n 8\n 9", 45)]
    public void AddTwoNumbersSeparatedByNewLineAndComma(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("23\n\n\n#46", 69)]
    [InlineData("//#\n1#2#3\n23#46", 75)]
    public void AddTwoNumbersSeparatedByAllDelimiters(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//#\n1#2,3\n1", 7)]
    [InlineData("//#\n23#46,\n1", 70)]
    public void AddTwoNumbersSeparatedByAllDelimitersAndPreviousOnes(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}
    