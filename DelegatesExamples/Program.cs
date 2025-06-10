using System;

namespace DelegatesExample
{
    public delegate int IntegerCalculation(int a, int b);

    class Program
    {
        private static int Add(int a, int b)
        {
            return a + b;
        }

        public static void RunMethodBasedDelegate()
        {
            IntegerCalculation adder = Add;

            Console.WriteLine("Output for Method-based Delegate:");
            Console.WriteLine("The result: " + adder(2, 4));
        }
        public static void RunAnonymousMethodDelegate()
        {
            IntegerCalculation adder = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine("Output for Anonymous Method Delegate:");
            Console.WriteLine("The result: " + adder(2, 4));
        }

        public static void RunLambdaDelegate()
        {
            IntegerCalculation adder = (a, b) => a + b;

            Console.WriteLine("Output for Lambda-based Delegate:");
            Console.WriteLine("The result: " + adder(2, 4));
        }

        static void Main(string[] args)
        {
            RunMethodBasedDelegate();
            Console.WriteLine();

            RunAnonymousMethodDelegate();
            Console.WriteLine();

            RunLambdaDelegate();

            Console.ReadLine();
        }
    }
}
