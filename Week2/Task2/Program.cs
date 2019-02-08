using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool Prime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i+=2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\hp\Desktop\Test\Input.txt");
            string s = sr.ReadToEnd();
            // string s = Console.ReadLine();
            int[] a = s.Split().Select(int.Parse).ToArray();
            List<int> l = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) l.Add(a[i]);
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\hp\Desktop\Test\Output.txt");
            for (int i = 0; i < l.Count; i++)
            {
                sw.Write(l[i] + " ");

            }
            sw.Close();
                 /* for(int i = 0; i < l.Count; i++)
                  {
                      Console.Write(l[i] + " ");
                  }*/


        }
    }
}
