using System;

namespace OpenCover
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Sum(2, 4));
            Console.Read();
        }
    }

    public class Calculator
    {
        public int Sum(int a, int b)
        {
            if(a==2)
            {
                return 6;
            }
            return a + b;
        }
    }
}
