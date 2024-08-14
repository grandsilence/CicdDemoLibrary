namespace CicdDemoLibrary.Tests;

public class CalculatorTests
{
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -1, -2)]
    [Theory]
    public void Sum(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        int actualResult = calculator.Sum(a, b);
        Assert.Equal(expectedResult, actualResult);
    }

    [InlineData(0, 0, 0)]
    [InlineData(1, 2, -1)]
    [InlineData(-1, -1, 0)]
    [Theory]
    public void Sub(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        int actualResult = calculator.Sub(a, b);
        Assert.Equal(expectedResult, actualResult);
    }

    [InlineData(100, 0, 0)]
    [InlineData(2, 2, 4)]
    [InlineData(-3, -3, 9)]
    [Theory]
    public void Mul(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        int actualResult = calculator.Mul(a, b);
        Assert.Equal(expectedResult, actualResult);
    }

}
