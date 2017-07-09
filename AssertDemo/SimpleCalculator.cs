using System;

namespace AssertDemo
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int value, int by)
        {
            if (value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Value should be less than 100.");
            }
            return value / by;
        }
    }
}
