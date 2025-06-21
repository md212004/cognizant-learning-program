using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieve the first instance of Logger
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            // Retrieve the second instance of Logger
            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            // Check if both references point to the same object
            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both logger instances are the same. Singleton confirmed.");
            }
            else
            {
                Console.WriteLine("Different instances detected. Singleton pattern failed.");
            }
        }
    }
}
