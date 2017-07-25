using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesDemo
{
    public class MemoryCalculator
    {
        public int CurrentValue { get; set; }

        public int Add(int a)
        {
            CurrentValue += a;
            return CurrentValue;
        }

        public int Subtract(int a)
        {
            CurrentValue -= a;
            return CurrentValue;
        }

        public int Divide(int numToDivide)
        {
            CurrentValue /= numToDivide;
            return CurrentValue;
        }
    }
}
