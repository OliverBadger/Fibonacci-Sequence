using Fibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        byte iterations = 100;

        ulong a = 1;
        ulong b = 0;
        calculation cal = new calculation();
        ulong nthTerm = cal.fibonacci(a, b, iterations);
        Console.WriteLine($"The {iterations} number in the sequence is {nthTerm}");
    }
}