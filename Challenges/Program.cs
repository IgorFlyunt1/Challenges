using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EdabitChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalculateExponent(5, 5);
            
            int[] i1 = {2, 6, 4, 9};
            var multiplyByLength = new MultiplyArrByLength();
            multiplyByLength.MultiplyByLength(i1);

        }

        

        private int? AreaofaTriangle(int baseHeight, int height) => (baseHeight * height) / 2;
        

        private double[] MinMaxNumbers(double[] values)
        {
            return new[] { values.Min(), values.Max() };
        }
        
        
        public static int? GetAbsoluteSum(int[] arr)
        {
           return arr.Sum(x => Math.Abs(x));
        }

        public static int Addition(int num)
        {
            return num + 1;
        }
        
        public static long CalculateExponent(long number, long exponent) 
        {
            return (long)Math.Pow(number, exponent);
        }

        public static string[] ParseArray(object[] arr)
        {
            return Array.ConvertAll(arr, x => x.ToString());
        }
        
        public static int[] GetOddNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 != 0).ToArray();
        }
        
        public static int[] GetEvenNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }
        
        
        
    }
}