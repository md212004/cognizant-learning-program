// ==============================
// Exercise 7: Financial Forecasting Using Recursion
// ==============================

using System;
using System.Collections.Generic;

namespace FinancialForecast
{
    class Program
    {
        // Basic recursive function to calculate future value
        static double ForecastRecursive(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;
            return ForecastRecursive(initialValue, growthRate, years - 1) * (1 + growthRate);
        }

        // Optimized version with memoization
        static Dictionary<int, double> memo = new Dictionary<int, double>();

        static double ForecastOptimized(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;

            if (memo.ContainsKey(years))
                return memo[years];

            double result = ForecastOptimized(initialValue, growthRate, years - 1) * (1 + growthRate);
            memo[years] = result;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial amount:");
            double initial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter annual growth rate (e.g., 0.1 for 10%):");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of years to forecast:");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValueRecursive = ForecastRecursive(initial, rate, years);
            double futureValueOptimized = ForecastOptimized(initial, rate, years);

            Console.WriteLine($"\n--- Forecast ---");
            Console.WriteLine($"Recursive Forecast after {years} years: ₹{futureValueRecursive:F2}");
            Console.WriteLine($"Optimized Forecast after {years} years: ₹{futureValueOptimized:F2}");
        }
    }
}
