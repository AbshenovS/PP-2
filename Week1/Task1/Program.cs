using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime(int k)                     //Function to check the number is prime or not
        {
            if (k <= 1) return false;
            else if (k == 2) return true;
            else if (k % 2 == 0) return false;              // Algorithm to check
            for (int i = 3; i <= Math.Sqrt(k); i += 2)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          //Convert entered string to integer type
            int[] a = new int[n];                           //New array
            string s = Console.ReadLine();                  //Entering elements of array in one string line
            a = s.Split(' ').Select(int.Parse).ToArray();   //Split string by space and convert every element to integer and make array of integers with them
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {                                               //Count prime numbers in array
                if (Prime(a[i]) == true) b++;
            }
            Console.WriteLine(b);                           //Write in console number of primes
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) Console.Write(a[i] + " ");     //Cycle to find prime numbers in array and write them in console
            }
        }

    }
}