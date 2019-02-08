using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Arr(int[] a)
        {
            int[] b = new int[2 * a.Length];
            int j = 0;
            for (int i = 0; i < b.Length - 1; i += 2)
            {
                b[i] = a[j];
                b[i + 1] = a[j];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string s = Console.ReadLine();
            a = s.Split(' ').Select(int.Parse).ToArray();
            Arr(a);
        }
    }
}
