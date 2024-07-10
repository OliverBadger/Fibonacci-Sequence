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
        uint sequence = n;
        n--; // The first number in the sequence is 0
        cache = new BigInteger[sequence];
        Console.WriteLine($"The answer for {sequence + 1} is {fibonacci(n)}");

        for(int i = 0; i< cache.Length; i++)
        {
            if (cache[i] == 0 && i < 1)
            {
                Console.WriteLine($"Sequence {(i + 1)} 0");
            }
            else if (cache[i] == 0 && i > 0)
            {
                Console.WriteLine($"Sequence {(i + 1)} 1");
            }
            else
            {
                // '{cache[i]:N0}' Adds a comma to make the number more readable
                Console.WriteLine($"Sequence {(i + 1)} {cache[i]:N0}");
            }
        }

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

        // Check if the value of the (n-1)th Fibonacci number is already cached (computed previously)
        if (cache[n - 1] != 0)
        {
            // If it is cached, return the cached value
            return cache[n - 1];
        }

        // Compute the (n-2)th and (n-1)th Fibonacci numbers recursively and sum them up
        BigInteger tempStore = fibonacci(n-2) + fibonacci(n-1);

        // Store the computed Fibonacci number in the cache for future use
        cache[n-1] = tempStore;

        // Return the computed Fibonacci number
        return tempStore;
    }

    // This is Trevors Method
}