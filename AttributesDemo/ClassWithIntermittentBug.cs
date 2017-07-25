using System;

namespace AttributesDemo
{
    public class ClassWithIntermittentBug
    {
        public void DoWork()
        {
            if (DateTime.Now.Ticks % 2 == 0)
            {
                //throw new ArithmeticException("Simulated Bug");
            }
        }
    }
}
