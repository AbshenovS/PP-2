using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        static bool Palin(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C: \Users\hp\Desktop\Test\Input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            if (Palin(s)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
