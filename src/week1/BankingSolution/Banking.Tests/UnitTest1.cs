namespace Banking.Tests;

// Has to be!
public class UnitTest1
{
    [Fact]
    public void CanAddTenAndTwenty()
    {
        // Arrange - Given
        int a = 10;
        int b = 20;
        int answer;
        // Act - When
        answer = a + b;
        // Asset - Then
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(5, 5, 10)]
    public void CanAddTwoIntegersToo(int a, int b, int expected)
    {
        int answer = a + b;
        Assert.Equal(expected, answer);
    }
}
