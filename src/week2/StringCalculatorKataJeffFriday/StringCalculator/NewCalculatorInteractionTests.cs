
namespace StringCalculator;

public class NewCalculatorInteractionTests
{
    [Fact]
    public void LogTheSum()
    {
        var mockedTest = Substitute.For<ILogger2>();
        var calc = new Calculator2(mockedTest);
        var result = calc.Add("2,2");
        mockedTest.Received().LogResult("4");

    }
}
