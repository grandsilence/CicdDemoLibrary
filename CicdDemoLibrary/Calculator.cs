namespace CicdDemoLibrary;

public sealed class Calculator : ICalculator
{
    public int Sum(int a, int b) => a + b + a + b; // TODO: fix it

    public int Sub(int a, int b) => a - b;

    public int Mul(int a, int b) => a * b;
}
