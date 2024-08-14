namespace CicdDemoLibrary;

public interface ICalculator
{
    /// <summary>
    /// Sum two numbers.
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Returns sum of two numbers</returns>
    int Sum(int a, int b);

    /// <summary>
    /// Subtract two numbers.
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Returns sub of two numbers</returns>
    int Sub(int a, int b);

    /// <summary>
    /// Multiply two numbers.
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Returns a * b</returns>
    int Mul(int a, int b);
}
