using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime(int k)
        {
            if (k <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string s = Console.ReadLine();
            a = s.Split(' ').Select(int.Parse).ToArray();
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) b++;
            }
            Console.WriteLine(b);
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) Console.Write(a[i] + " ");
            }
        }

    }
}