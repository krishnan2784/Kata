using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Kata.Domain
{
    public static class FactorialCalculator
    {

        public static string Factorial(int n)
        {
            if(n<=0) 
                return "1";
            var result =   factorialRecursion(n);
            return String.Format("{0:F0}", result);
        }
  
        public static double factorialRecursion(int number)
        {
            if (number == 1)
                return 1;
            return number * factorialRecursion(number - 1);
        }

    }
}