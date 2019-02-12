using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Arr(int[] a)                 //method to make new array
        {
            int[] b = new int[2 * a.Length];            //new array with doubled lengh of given array
            int j = 0;
            for (int i = 0; i < b.Length - 1; i += 2)
            {
                b[i] = a[j];                            //cycle to make elements of array
                b[i + 1] = a[j];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {                                            //cycle to write elements of array in console
                Console.Write(b[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());      //size of array converted to integer from entered string
            int[] a = new int[n];                       //new array with given size
            string s = Console.ReadLine();
            a = s.Split(' ').Select(int.Parse).ToArray();   //making array from elements firstly splited by space from entered string and after converted to integer type
            Arr(a);                                     //call of method
        }
    }
}
