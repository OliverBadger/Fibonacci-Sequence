using Fibonacci;
using System.Net.Http.Headers;
using System.Numerics;

internal class Program
{
    // Trevors method
    private static BigInteger[]? cache;
    // Trevors method

    private static void Main(string[] args)
    {
        // This is my method

        //byte iterations = 100;

        //ulong a = 1;
        //ulong b = 0;
        //calculation cal = new calculation();

        //Console.WriteLine($"The {iterations} number in the sequence is {cal.fibonacci(a, b, iterations)}");
        
        // This is my method



        // This is Trevors Method

        uint n = 100;
        n--;
        uint sequence = n + 1;
        calculation cal = new calculation();
        cache = new BigInteger[sequence];
        Console.WriteLine($"The answer for {sequence + 1} is {fibonacci(n)}");

        // This is Trevors Method
    }

    // This is Trevors Method

    private static BigInteger fibonacci(uint n)
    {
        if (n <= 1)
        {
            return n;
        }
        //else
        //{
        //    return fibonacci(n - 2) + fibonacci(n - 1);
        //}
        if (cache[n - 1] != 0)
        {
            return cache[n - 1];
        }

        BigInteger tempStore = fibonacci(n-2) + fibonacci(n-1);
        cache[n-1] = tempStore;
        return tempStore;
    }

    // This is Trevors Method
}