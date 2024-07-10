﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class calculation
    {
        private byte count;
        public int fibonacci(int a, int b, int totalCount)
        {
            // c = Fn
            // a = F(n-1)
            // b = F(n-2)

            int c = a + b;
            if (count == totalCount)
            {
                Console.WriteLine($"For itteration {count}, the result is {c}. This means the calculation is {a} + {b} = {c}");
                return c;
            }
            else
            {
                count++;
                fibonacci(c, a, totalCount);
                return c;
            }
        }
    }
}