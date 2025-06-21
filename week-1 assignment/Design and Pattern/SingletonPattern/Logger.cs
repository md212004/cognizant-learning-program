using System;

namespace SingletonPatternExample
{
    /// <summary>
    /// Logger class implementing Singleton Design Pattern.
    /// This ensures only one instance of Logger is used throughout the application.
    /// </summary>
    public class Logger
    {
        // Static instance variable to hold the single instance of Logger
        private static Logger? _instance;

        // Object used for thread safety (optional for multithreaded apps)
        private static readonly object _lock = new object();

        /// <summary>
        /// Private constructor to prevent instantiation from other classes.
        /// </summary>
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        /// <summary>
        /// Public static method to get the single instance of Logger.
        /// Uses lazy initialization with thread safety.
        /// </summary>
        public static Logger GetInstance()
        {
            // Double-checked locking to avoid multiple threads creating new instances
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// Method to log a message to the console.
        /// </summary>
        public void Log(string message)
        {
            Console.WriteLine("Log Entry: " + message);
        }
    }
}
