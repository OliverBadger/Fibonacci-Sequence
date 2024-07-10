using Fibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        int iterations = 100;

        int a = 1;
        int b = 0;
        calculation cal = new calculation();
        int nthTerm = cal.fibonacci(a, b, iterations);
        Console.WriteLine($"The {iterations} number in the sequence is {nthTerm}");
    }
}